<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebQuanLyDoiBong.aspx.cs" Inherits="QuanLyDoiBong.Models.WebQuanLyDoiBong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 950px;
        }
        .auto-style2 {
            width: 120px;
        }
        .auto-style4 {
            width: 208px;
        }
        .auto-style5 {
            width: 150px;
        }
        .auto-style6 {
            width: 126px;
        }
        .auto-style7 {
            width: 120px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</head>
<body style="font-size:larger; margin-left: 300px">
    <form id="form1" runat="server">

        <table class="auto-style1">
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblDoiBong" runat="server">Hiển thị dữ liệu theo tên đội bóng:</asp:Label></td>
                <td colspan="4">
                    <asp:DropDownList ID="cboDoiBong" runat="server" Width="300px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList></td>

                <td>
                    <asp:Button ID="btnThemDoiBong" runat="server" Text="+" Width="30px" /></td>
                <td colspan="2">
                    <asp:Button ID="btnHienThi" runat="server" Text="Hiển thị danh sách cầu thủ" Width="300px" OnClick="btnHienThi_Click" /></td>
            </tr>
            <tr>
                <td colspan="11">
                    <asp:GridView ID="DGVCauThu" SelectedIndex="1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="DGVCauThu_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField ItemStyle-Width="200px" DataField="MaCauThu" HeaderText="Mã cầu thủ">
                                <ItemStyle Width="200px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField ItemStyle-Width="200px" DataField="TenCauThu" HeaderText="Tên cầu thủ">
                                <ItemStyle Width="200px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField ItemStyle-Width="200px" HeaderText="Số điện thoại" DataField="Sodt">
                                <ItemStyle Width="200px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField ItemStyle-Width="200px" HeaderText="Email" DataField="Email">
                                <ItemStyle Width="200px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField ItemStyle-Width="150px" HeaderText="IdDoiBong" DataField="IdDoiBong">
                                <ItemStyle Width="150px"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkselect" Text="Chọn" runat="server" CommandArgument='<%#Eval("MaCauThu")%>' OnClick="lnkselect_Click"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>

        </table>
        <table class="auto-style1">
            <tr>
                <td colspan="3" class="auto-style7">
                    <asp:Label ID="lblMaCauThu" runat="server" Text="Mã cầu thủ:"></asp:Label>
                </td>
                <td colspan="4" class="auto-style8">
                    <asp:TextBox ID="tbxMaCauThu" runat="server" Width="320px"></asp:TextBox>
                </td>
                <td colspan="2" class="auto-style8">
                    <asp:Label ID="lblTenCauThu" runat="server" Text="Tên cầu thủ:"></asp:Label>
                </td>
                <td colspan="4" class="auto-style8">
                    <asp:TextBox ID="tbxTenCauThu" runat="server" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style2">
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="tbxEmail" runat="server" Width="320px" Height="23px"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Label ID="lblSoDT" runat="server" Text="Số điện thoại:"></asp:Label>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="tbxSoDT" runat="server" Width="320px" Height="23px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblMaDoiBong" runat="server" Text="Mã đội bóng:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="tbxMaDoiBong" runat="server" Width="179px" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnThemCauThu" runat="server" Text="Thêm" Width="140px" /></td>
                <td class="auto-style5">
                    <asp:Button ID="btnLuu" runat="server" Text="Lưu" Width="140px" /></td>
                <td class="auto-style5">
                    <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" Width="140px" /></td>
                <td>
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="140px" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
