<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InvokeCsMethodFromJavaScript.aspx.cs" Inherits="WebApplication.Pages.InvokeCsMethodFromJavaScript" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script type="text/javascript">
            $(document).ready(function () {

                $('#btnClickDemoJS').click(function() {
                    console.log('entro');

                    var pageUrl = '<%= ResolveUrl("~/Pages/InvokeCsMethodFromJavaScript.aspx/JQueryAjaxCall") %>';
                    var data1 = 'mydata1';
                    var data2 = 'mydata2';
                    var parameter = { "data1": data1, "data2": data2 };

                    function onSuccess(data) {
                        alert(data.d);
                    }

                    $.ajax({
                        type: 'POST',
                        url: pageUrl,
                        data: JSON.stringify(parameter),
                        contentType: 'application/json; charset=utf-8',
                        dataType: 'json',
                        success: function(data) {
                            onSuccess(data);
                        },
                        error: function(data, success, error) {
                            alert("Error : " + error + " <-> " + data);
                        }
                    });
                });

            });
        </script>

    <br/>
    <br/>
    
    <asp:UpdatePanel runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <ContentTemplate>
            <div style="text-align: center">
                <input type="button" id="btnClickDemoJS" value="show data" class="btn btn-info"/>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>