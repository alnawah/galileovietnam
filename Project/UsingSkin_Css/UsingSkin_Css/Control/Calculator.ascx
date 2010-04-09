<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calculator.ascx.cs" Inherits="UsingSkin_Css.Control.WebUserControl1" %>
<asp:Label ID="Label1" runat="server" Text="Nhập a:"></asp:Label>
<asp:TextBox ID="txta" runat="server"></asp:TextBox>&nbsp;
<asp:Label ID="Label2" runat="server" Text="Nhập b:"></asp:Label>
<asp:TextBox ID="txtb" runat="server"></asp:TextBox>
<hr />
<asp:Button ID="btnSum" OnCommand="Calculator" CommandName="cal" CommandArgument="sum" runat="server" Text="+" Width="45px"/>
<asp:Button ID="btnSub" OnCommand="Calculator" CommandName="cal" CommandArgument="sub" runat="server" Text="-" Width="45px"/>
<asp:Button ID="btnmul" OnCommand="Calculator" CommandName="cal" CommandArgument="mul" runat="server" Text="x" Width="45px"/>
<asp:Button ID="btnDiv" OnCommand="Calculator" CommandName="cal" CommandArgument="div" runat="server" Text="/" Width="45px"/>
<hr />
<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
<hr />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ErrorMessage="Bạn phải nhập a" ControlToValidate="txta" Visible="false">
    </asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator1" runat="server" 
    ErrorMessage="a phải là kiểu nguyên" ControlToValidate="txta" 
    Type="Integer" MaximumValue="999999" MinimumValue="0" Visible="false">
    </asp:RangeValidator>
    
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ErrorMessage="Bạn phải nhập b" ControlToValidate="txtb" Visible="false">
    </asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator2" runat="server" 
    ErrorMessage="b phải là kiểu nguyên" ControlToValidate="txtb" 
    Type="Integer" MaximumValue="999999" MinimumValue="1" Visible="false">
    </asp:RangeValidator>
<p>&nbsp;</p>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
