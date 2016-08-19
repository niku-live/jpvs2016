using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Skaiciuotuvas
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    
    public string Calculate(string number1Text, string number2Text, string operation)
    {
      int number1;
      int number2;
      if (!int.TryParse(number1Text, out number1))
      {
        return "Klaida: pirmas duomuo nėra skaičius";
      }
      if (!int.TryParse(number2Text, out number2))
      {
        return "Klaida: antras duomuo nėra skaičius";
      }
      int result = 0;
      switch (operation)
      {
        case "+":
          result = number1 + number2;
          break;
        case "-":
          result = number1 - number2;
          break;
        case "*":
          result = number1 * number2;
          break;
        case "/":
          result = number1 / number2;
          break;
        case "%":
          result = number1 % number2;
          break;					
      }
      return String.Format("{0} {1} {2} = {3}", number1, operation, number2, result);
    }
        
    
    public void Button1Click(object sender, EventArgs e)
    {
      textBox3.Text = Calculate(textBox1.Text, textBox2.Text, "+");
    }
    
    public void Button2Click(object sender, EventArgs e)
    {
      textBox3.Text = Calculate(textBox1.Text, textBox2.Text, "-");
    }
    
    public void Button3Click(object sender, EventArgs e)
    {
      textBox3.Text = Calculate(textBox1.Text, textBox2.Text, "*");
    }
    
    public void Button4Click(object sender, EventArgs e)
    {
      textBox3.Text = Calculate(textBox1.Text, textBox2.Text, "/");
    }
  }
}
