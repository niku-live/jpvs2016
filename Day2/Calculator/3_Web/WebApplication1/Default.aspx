<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<form runat="server">
  <div>
    <asp:label text="Skaičius 1:" runat="server"></asp:label>
    <asp:textbox id="textBox1" runat="server"></asp:textbox>
    <br />
    <asp:label text="Skaičius 2:" runat="server"></asp:label>
    <asp:textbox id="textBox2" runat="server"></asp:textbox>
    <br />
    <asp:label text="Rezultatas:" runat="server"></asp:label>
    <asp:textbox id="textBox3" runat="server"></asp:textbox>
    <br />
    <asp:button runat="server" text="+" OnClick="Button1Click" />
    <asp:button runat="server" text="-" OnClick="Button2Click" />
    <asp:button runat="server" text="*" OnClick="Button3Click" />
    <asp:button runat="server" text="/" OnClick="Button4Click" />
  </div>
</form>

