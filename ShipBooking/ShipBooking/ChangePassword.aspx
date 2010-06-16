<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ShipBooking.ChangePassword" MasterPageFile="~/Admin_Master.Master" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="ChangePasswordContent" runat="server">
    <center>
        <br />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:ChangePassword ID="ChangePassword1" runat="server">
            <ChangePasswordTemplate>
                <table border="0" cellpadding="1" cellspacing="0" 
                    style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="CurrentPasswordLabel" runat="server" 
                                            AssociatedControlID="CurrentPassword">Mật khẩu hiện tại:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" 
                                            ControlToValidate="CurrentPassword" ErrorMessage="Password is required." 
                                            ToolTip="Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="NewPasswordLabel" runat="server" 
                                            AssociatedControlID="NewPassword">Mật khẩu mới:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" 
                                            ControlToValidate="NewPassword" ErrorMessage="New Password is required." 
                                            ToolTip="New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="ConfirmNewPasswordLabel" runat="server" 
                                            AssociatedControlID="ConfirmNewPassword">Xác nhận mật khẩu mới:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" 
                                            ControlToValidate="ConfirmNewPassword" 
                                            ErrorMessage="Confirm New Password is required." 
                                            ToolTip="Confirm New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:CompareValidator ID="NewPasswordCompare" runat="server" 
                                            ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" 
                                            Display="Dynamic" 
                                            ErrorMessage="Mật khẩu xác nhận không đúng, hãy nhập lại!" 
                                            ValidationGroup="ChangePassword1"></asp:CompareValidator>
                                    </td>
                                </tr>
                                
                            </table>
                        </td>
                    </tr>
                </table>
            </ChangePasswordTemplate>
        </asp:ChangePassword>
        <asp:Button ID="Button1" runat="server" Height="26px" onclick="Button1_Click" 
            Text="Đổi mật khẩu" Width="112px" ValidationGroup="ChangePassword1" />
        <br />
        <br />
    </center>
</asp:Content>
