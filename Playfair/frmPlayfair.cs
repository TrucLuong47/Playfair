using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Playfair
{
    public partial class frmPlayfair : Form
    {  
        public frmPlayfair()
        {
            InitializeComponent();
        }
        
        //Khai báo

        string key = ""; // chuỗi Khóa

        string kiTu; // các kí tự trong bảng chữ cái Alphabet trừ chữ "j"

        char[,] hopMatrix_2D = new char[5,5]; // Ma trận kí tự Khóa 2D

        char[,] cap_kitu = new char[200,200];  // Cặp kí tự

        int numberOfBinary = 0; //mảng 2 chiều, nhiều hàng, cột chứa các cặp ký tự có trong chuỗi nhập vào .
        
        char[,] _result = new char[200,200]; // Kết quả Mã hóa, giải Mã
        
        int[] location = new int[4];  // vị trí cho các cặp
       
     

        // Hiển thị văn bản được mã hóa hoặc giải mã trên màn hình kết quả (output)
        public string result()
        {
            string resultText = "";
            

            for(int i = 0; i < numberOfBinary; i++)
            {
                resultText += _result[i, 0].ToString() + _result[i, 1].ToString();
            }

            return resultText;
        }

        // GIẢI MÃ
        public void decrypt()
        {     
            for (int i = 0; i < numberOfBinary; i++)
            {
                //tìm vị trí của các cặp kí tự
                findLocation(cap_kitu[i, 0], cap_kitu[i, 1]);

                //Cặp chữ cái cùng hàng
                //Nếu hai chữ cái trong bảng mã cùng một hàng/dòng của ma trận khóa thì được thay thế bằng chữ cái bên trái
                if (location[0] == location[2]) 
                {
                    if (location[1] == 0)
                    {
                        _result[i, 0] = hopMatrix_2D[location[0], 4];
                        _result[i, 1] = hopMatrix_2D[location[0], (location[3] - 1) % 5];
                    }
                    else if (location[3] == 0)
                    {
                        _result[i, 0] = hopMatrix_2D[location[0], (location[1] - 1) % 5];
                        _result[i, 1] = hopMatrix_2D[location[0], 4];
                    }
                    else
                    {
                        _result[i, 0] = hopMatrix_2D[location[0], (location[1] - 1) % 5];
                        _result[i, 1] = hopMatrix_2D[location[2], (location[3] - 1) % 5];
                    }
                }

                //Cặp chữ cái cùng cột
                //Nếu hai chữ cái trong bảng mã cùng một cột của ma trận khóa thì sẽ được thay thế bằng các chữ cái ở trên
                else if (location[1] == location[3]) 
                {
                    if (location[0] == 0)
                    {
                        _result[i, 0] = hopMatrix_2D[4, location[1]];
                        _result[i, 1] = hopMatrix_2D[(location[2] - 1) % 5, location[1]];
                    }
                    else if (location[2] == 0)
                    {
                        _result[i, 0] = hopMatrix_2D[(location[0] - 1) % 5, location[1]];
                        _result[i, 1] = hopMatrix_2D[4, location[1]];
                    }
                    else
                    {
                        _result[i, 0] = hopMatrix_2D[(location[0] - 1) % 5, location[1]];
                        _result[i, 1] = hopMatrix_2D[(location[2] - 1) % 5, location[1]]; 
                    }
                }

                //Các trường hợp khác, mỗi chữ cái được thay bởi chữ cái khác cùng hàng, trên cột chữ cái cùng cặp
                else 
                {
                    _result[i, 0] = hopMatrix_2D[location[0], location[3]];
                    _result[i, 1] = hopMatrix_2D[location[2], location[1]];
                }
            }
        }

        // MÃ HÓA
        public void encrypt()
        {
            for (int i = 0; i < numberOfBinary; i++)
            {
                //Tìm vị trí của các cặp kí tự
                findLocation(cap_kitu[i,0], cap_kitu[i,1]);

                //Cặp chữ cái cùng hàng
                //Nếu hai chữ cái trong bảng mã cùng một hàng/dòng của ma trận khóa thì được thay thế bằng chữ cái bên trái
                if (location[0] == location[2]) 
                {
                    _result[i, 0] = hopMatrix_2D[location[0], (location[1]+1) % 5];
                    _result[i, 1] = hopMatrix_2D[location[2], (location[3]+1) % 5];
                }

                //Cặp chữ cái cùng cột
                //Nếu hai chữ cái trong bảng mã cùng một cột của ma trận khóa thì sẽ được thay thế bằng các chữ cái ở trên
                else if (location[1] == location[3]) 
                {
                    _result[i, 0] = hopMatrix_2D[(location[0]+1) % 5, location[1]];
                    _result[i, 1] = hopMatrix_2D[(location[2]+1) % 5, location[3]]; 
                }

                //Các trường hợp khác, mỗi chữ cái được thay bởi chữ cái khác cùng hàng, trên cột chữ cái cùng cặp
                else 
                {
                    _result[i, 0] = hopMatrix_2D[location[0],location[3]];
                    _result[i, 1] = hopMatrix_2D[location[2],location[1]];
                }
            }
        }

        // Tìm 2 ký tự tương ứng trong ma trận khóa và trả về vị trí
        public void findLocation(char ch1, char ch2)
        {
            // Nếu gặp kí tự "j" thì ta thay bằng "i"
            if (ch1 == 'j')
            {
                ch1 = 'i';
            }
            else if (ch2 == 'j')
            {
                ch2 = 'i';
            }

            //Tiến hành tìm kiếm và trả về vị trí
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //Nếu phần tử trong ma trận = kí tự đầu tiên
                    if (hopMatrix_2D[i,j] == ch1)
                    {
                        location[0] = i;  // dòng
                        location[1] = j;  // cột
                    }

                    //Còn nếu phần tử trong ma trận bằng kí tự thứ 2
                    else if (hopMatrix_2D[i, j] == ch2)
                    {
                        location[2] = i;
                        location[3] = j;
                    }
                }
            }
        }


       // Tạo thành từng cặp ký tự trong input text
       public void createBinary(string text)
        {
            int j = 0;

            //xử lý raw data, xóa khoảng trắng
            text = text.Trim().Replace(" ", "");

            if(text.Length % 2 != 0) //nếu số kí tự đầu vào lẻ thì ta thêm "x" vào sau
            {
                text += "x";
            }

            for (int i = 0; i < text.Length-1; i+=2)
            {
                cap_kitu[j, 0] = text[i]; //thêm giá trị vào cột đầu tiên, hàng đầu tiên
                cap_kitu[j, 1] = text[i + 1];
                
                j++;
            }

            numberOfBinary = j;
        }

       
        // Tạo ma trận khóa
        public void create_KeyMatrix()
        {
            int j = 0;
            int k = 0;
            int i = key.Length;
            int index1 = 0;

            kiTu = "abcdefghiklmnopqrstuvwxyz"; // 25 kí tự trong ma trận khóa trừ "j"

            //Điều kiện của tạo ma trận với khóa x nhập vào
            while(i > 0)
            {

                //cam kết khóa cho hộp và trừ các toán hạng hộp khỏi tập ký tự
                //không cho các ký tự lặp lại được đưa vào ô 2 lần.
                index1 = kiTu.IndexOf(key[key.Length - i]);
                if (index1 >= 0)
                {
                    hopMatrix_2D[k,j] = key[key.Length - i];
                    kiTu = kiTu.Remove(index1, 1);
                    j++;
                }
                
                i--;

                if (j == 5) 
                {
                    k++;
                    j = 0;
                }
            }
            i = 0;  //sẽ được sử dụng lại để xử lý các ký tự còn lại
   

            //Xử lý các ký tự còn lại
            while (i < kiTu.Length)
            {
                hopMatrix_2D[k,j] = kiTu[i];

                i++;
                j++;

                if (j % 5 == 0)
                {
                    k++;
                    j = 0;
                }
            }
        }

        // In ma trận ra textbox Matrix
        public void printMatrix()
        {
            tb_Matrix.Text = "";

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    tb_Matrix.Text += hopMatrix_2D[i - 1, j - 1] + "\r\t";
                }
                tb_Matrix.Text += "\r\n\r\n";
            }
        }

        // Class kiểm tra các ký tự nhập trong Key khóa ko thể nhận ra trong textbox Key
        public string check_InputKey(string text)
        {
            
            //Nếu có một ký tự không xác định trong nhập chuỗi khóa (Key) ,ta sẽ xóa nó.

            for (int i = text.Length - 1; i >= 0; i--)
            {
                //Cho phép nhập các kí tự trong bảng chữ cái Alphabet không tính chữ "j"
                if (!((text[i] >= 97 && text[i] <= 106) || (text[i] >= 107 && text[i] <= 122) )) 
                {
                    text = text.Remove(i, 1); //Còn lại các kí tự không có trong điều kiện thì sẽ bị loại bỏ
                }
            }
            return text;
        }

        // Class kiểm tra các kí tự đầu vào ko thể nhận ra trong textbox input
        public string check_InputCharacters(string text) 
        {
            //Cho phép nhập các kí tự trong bảng chữ cái Alphabet
            for (int i = text.Length - 1; i >= 0; i-- ){
                if (!(text[i] == ' ' ||  (text[i] >= 97 && text[i] <= 122) ))
                {
                    text = text.Remove(i, 1); //các kí tự còn lại không có trong điều kiện thì sẽ bị loại bỏ
                }
            }
            return text;
        }


        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (tb_Key.Text == " ")
            {   
                key = " ";
            }
            else 
            {    
                tb_Key.Text = check_InputKey(tb_Key.Text); // kiểm tra các kí tự được nhập vào chuỗi key khóa
                tb_Key.Select(tb_Key.Text.Length, 0); //Con trỏ nằm ở cuối đoạn text
                key = tb_Key.Text;
            }
            create_KeyMatrix();
            printMatrix();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (tb_Input.Text == "")
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
            else
            {
                tb_Input.Text = check_InputCharacters(tb_Input.Text); // kiểm tra các kí tự đầu vào được nhập trong textbox Input
                tb_Input.Select(tb_Input.Text.Length, 0); //Con trỏ nằm cuối đoạn text
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }

            // Bộ đếm các kí tự còn lại được nhập vào textbox Input
            if(tb_Input.Text.Length < 300001)
                lblGirdiMetniSay.Text = "("+ (300000 - tb_Input.Text.Length).ToString() +")";
            
        } 

        //Các Sự kiện xảy ra khi nhấn button Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            createBinary(tb_Input.Text); //Tạo thành các cặp ký tự từ chuỗi txt đầu vào

            encrypt(); // tiến hành mã hóa

            tb_Output.Text = result(); // xuất kết quả mã hóa ra textbox OutPut
        }

        //Các Sự kiện khi nhấn button Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {    
            createBinary(tb_Input.Text); //Tạo thành các cặp ký tự từ chuỗi txt đầu vào

            decrypt(); // Tiến hành giải mã

            tb_Output.Text = result();  // xuất kết quả mã hóa ra textbox OutPut
        }

        // btnSwitch lấy các kí tự đã được chuyển đổi(Mã hóa, Giải mã) từ tb_Output về tb_Input
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            tb_Input.Text = tb_Output.Text;
            tb_Output.Text = "";
        }

        private void frmPlayfair_Load(object sender, EventArgs e)
        {
            create_KeyMatrix();
            printMatrix();
        }


        private void txtMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGirdiMetniSay_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
