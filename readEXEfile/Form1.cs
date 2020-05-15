using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace readEXEfile
{
    public partial class Form1 : Form
    {
        SerialPort _serialComport = new SerialPort();
        public byte[] nmbufer;
        public byte[] nm_buf = new byte[100];
        public byte[] nm_buff = new byte[1];
        public int kkk = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 1;

            textt.Select();

            _serialComport.PortName = comboBox1.Text;
            _serialComport.BaudRate = int.Parse(comboBox2.Text);
            _serialComport.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.Text);
            _serialComport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox4.Text);
            _serialComport.DataBits = int.Parse(comboBox5.Text);
            _serialComport.Handshake = Handshake.None;
            _serialComport.ReadTimeout = 2000;
            _serialComport.WriteTimeout = 2000;
        }

        private void openCom_Click(object sender, EventArgs e)
        {
            //SerialPort _serialport1 = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One);
            try
            {
                _serialComport.Open();
                send_text_to_textbox1("Порт открыт:  "
                    + (_serialComport.PortName, _serialComport.BaudRate, _serialComport.DataBits, _serialComport.Parity, _serialComport.StopBits));
            }
            catch
            {
                send_text_to_textbox1("Порт уже открыт или недоступен");
            }
            scroll_down();
        }

        private void closeCom_Click(object sender, EventArgs e)
        {
            _serialComport.Close();
            send_text_to_textbox1("Порт закрыт:  " + (_serialComport.PortName));
            //this.Close(); //закрывает программу
            scroll_down();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialComport.PortName = comboBox1.Text;
                _serialComport.BaudRate = int.Parse(comboBox2.Text);
                _serialComport.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.Text);
                _serialComport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox4.Text);
                _serialComport.DataBits = int.Parse(comboBox5.Text);
                _serialComport.Handshake = Handshake.None;
                _serialComport.ReadTimeout = 2000;
                _serialComport.WriteTimeout = 2000;
                send_text_to_textbox1("Настрорйки Последовательного порта: "
                    + (_serialComport.PortName, _serialComport.BaudRate, _serialComport.DataBits, _serialComport.Parity, _serialComport.StopBits));

            }
            catch
            {
                send_text_to_textbox1("Для настройки последовательного порта необходимо ЗАКРЫТЬ его!");
            }
            scroll_down();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearScrin_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void response_Click(object sender, EventArgs e) //удалена
        {
            try
            {
                //var nmfile = File.ReadAllBytes(@"d:\nfp.exe");
                string pathfile = textBox2.Text;
                nmbufer = File.ReadAllBytes(pathfile);
                send_text_to_textbox1("Файл записан в Буфер программы его размер: " + nmbufer.Length);
            }
            catch
            {
                send_text_to_textbox1("Файл отсутствует по указанному пути");
                send_text_to_textbox1("Введите в строку выше путь и название файла с расширением .exe, который хотите прочитать");
            }
            scroll_down();
        }

        private void savefile_Click(object sender, EventArgs e) //удалена
        {
            try
            {
                File.WriteAllBytes(@"d:\nfp2.exe", nmbufer);
                send_text_to_textbox1("Файл из буфера записан в корень диска D: с названием nfp2.exe");
            }
            catch
            {
                send_text_to_textbox1("Буфер пуст");
            }
            scroll_down();
        }

        private void sent_Click(object sender, EventArgs e)
        {
            textBox1.Select(textBox1.Text.Length, 0);
            if (!_serialComport.IsOpen)
            {
                send_text_to_textbox1("Откройте последовательный порт!");
            }
            else
            {
                try
                {
                    if (textt.Checked == true)
                    {
                        string zapr;
                        string otv;
                        zapr = textBox2.Text;
                        //_serialComport.WriteLine(zapr);
                        zapr += "\r";
                        _serialComport.Write(zapr);
                        textBox1.Text += Environment.NewLine;
                        textBox1.Text += "Ответ: ";
                        Thread.Sleep(100);
                        if (_serialComport.BytesToRead != 0)
                        {                    
                            if (_serialComport.BytesToRead > 300)
                            {
                                for (int i = 0; i < 50; i++)
                                {
                                     if(_serialComport.BytesToRead > 0)
                                     {
                                          if (_serialComport.BytesToRead < 3)
                                          {
                                              otv = _serialComport.ReadExisting();
                                              send_text_to_textbox1(otv);
                                          }
                                          else
                                          {
                                              otv = _serialComport.ReadLine();
                                              send_text_to_textbox1(otv);
                                          }
                                     }
                                }
                            }
                            else
                            {
                                otv = _serialComport.ReadExisting();
                                textBox1.Text += otv;
                            }                                
                        }
                        else
                        {
                            send_text_to_textbox1("Ответа нет!");
                        }
                    }
                    else
                    {
                        send_text_to_textbox1("hex");
                    }
                }
                catch
                {
                    send_text_to_textbox1("Ошибка чтения");
                }
            }
            scroll_down();
        }

        private void button_read_com_Click(object sender, EventArgs e)
        {
            if (!_serialComport.IsOpen)
            {
                send_text_to_textbox1("Откройте последовательный порт!");
            }
            else
            {
                if (nm_buff.Length == 1)
                {
                    send_text_to_textbox1("Размер буфера не определен! Нажмите 'Узнать размер'");
                }
                else
                {
                    send_text_to_textbox1("Идет процесс скачивание файла! Ожидайте!");
                    for (long ii = 0; ii < 300; ii += 1)
                    {
                        _serialComport.Write("MDS " + ii + "\r");
                        Thread.Sleep(140);
                        int buf_bytes = _serialComport.BytesToRead;
                        byte[] nm_buffer = new byte[buf_bytes];
                        _serialComport.Read(nm_buffer, 0, buf_bytes);
                        //textBox1.Text += (" !!! " + nm_buffer.Length + "   ");
                        //send_text_to_textbox1 (BitConverter.ToString(nm_buffer));
                        if (buf_bytes > 1003)
                        {
                            int j = (buf_bytes - 1003);
                            for (int i = 0; i < 1000; i++)
                            {
                                nm_buff[kkk] = nm_buffer[i + j];
                                kkk++;
                            }
                        }
                        else
                        {
                            int j = (buf_bytes - (buf_bytes - 7));
                            for (int i = 0; i < (buf_bytes - 10); i++)
                            {
                                nm_buff[kkk] = nm_buffer[i + j];
                                kkk++;
                            }
                            kkk = 0;
                            break;
                        }
                    }
                    //File.WriteAllBytes(@"d:\!\2\nfp.exe", nm_buff);
                    //send_text_to_textbox1("Файл из буфера записан на D:-!-2  с названием nfp.exe");
                    send_text_to_textbox1("Загрузка завершена");
                    send_text_to_textbox1("Размер файла: " + nm_buff.Length);
                    //send_text_to_textbox1(BitConverter.ToString(nm_buff));
                }
            }
            scroll_down();
        }

        void scroll_down()
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
        
        void send_text_to_textbox1(string str)
        {
            textBox1.Text += str;
            textBox1.Text += Environment.NewLine;
        }

        private void button_com_Click(object sender, EventArgs e) //удалена
        {
            byte[] buf = { 0x01, 0x12, 0x23, 0x34, 0x45, 0x56, 0x67, 0x78, 0x89, 0x90, 0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xf0};
            int j = (buf.Length - 13);
            for (int i = 0; i < 10; i++)
            {
                nm_buf[kkk] = buf[i + j];
                kkk++;
            }

            send_text_to_textbox1(BitConverter.ToString(nm_buf));
            send_text_to_textbox1(" " + nm_buf.Length);

            scroll_down();
        }

        private void button_razmer_Click(object sender, EventArgs e)
        {
            if (!_serialComport.IsOpen)
            {
                send_text_to_textbox1("Откройте последовательный порт!");
            }
            else
            {
                _serialComport.Write("SIZE\r");
                Thread.Sleep(100);
                if (_serialComport.BytesToRead != 0)
                {
                    //textBox1.Text += "Ответ: ";
                    string otv = _serialComport.ReadExisting();
                    //send_text_to_textbox1(otv);
                    string str = "";
                    foreach (char ch in otv)
                    {
                        if (char.IsDigit(ch))
                        {
                            str += ch;   
                        }
                    }
                    int size = Convert.ToInt32(str);
                    nm_buff = new byte[size];
                    send_text_to_textbox1("Размер буфера для записи = " + nm_buff.Length);
                }
                else
                {
                    send_text_to_textbox1("Ответа нет! Проверте связь");
                }
            }
        }

        private void button_save_exe_Click(object sender, EventArgs e)
        {
            if (nm_buff.Length == 1)
            {
                send_text_to_textbox1("Размер буфера не определен! Нажмите 'Узнать размер'");
            }
            else                    
            {
                if (nm_buff[0] == 0x00 && nm_buff[1] == 0x00 && nm_buff[1] == 0x00)
                {
                    send_text_to_textbox1("Размер буфера определен но буфер пуст! Нажмите 'Скачать EXE файл'");
                }
                else
                {
                    if(textBox2.Text == "")
                    {
                        try
                        {
                            string put = textBox2.Text;
                            File.WriteAllBytes(@"d:\!\2\nfp.exe", nm_buff);
                            send_text_to_textbox1("Файл из буфера записан на d:\\!\\2\\nfp.exe");
                        }
                        catch
                        {
                            send_text_to_textbox1("Создайте папки d:\\!\\2, либо в строке выше укажите путь для сожранения и " +
                                "название файла с расширением .ЕХЕ и нажмите 'Сханить файл'");
                        }
                    }
                    else
                    {
                        try
                        {
                            string put = textBox2.Text;
                            File.WriteAllBytes(put, nm_buff);
                            send_text_to_textbox1("Файл записан на " + put);
                        }
                        catch
                        {
                            send_text_to_textbox1("Не верно указан путь для сохранения файла!");
                        }
                    }
                }
            }
        }
    }
}
