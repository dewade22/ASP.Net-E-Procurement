#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\ViewMyReject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a717619d6c744e0cc2a4ad8cb5cb34dbba389c1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseRequest_ViewMyReject), @"mvc.1.0.view", @"/Views/PurchaseRequest/ViewMyReject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseRequest/ViewMyReject.cshtml", typeof(AspNetCore.Views_PurchaseRequest_ViewMyReject))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement;

#line default
#line hidden
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\_ViewImports.cshtml"
using Balimoon_E_Procurement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a717619d6c744e0cc2a4ad8cb5cb34dbba389c1d", @"/Views/PurchaseRequest/ViewMyReject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseRequest_ViewMyReject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\PurchaseRequest\ViewMyReject.cshtml"
  
    ViewData["Title"] = "My Rejected PR";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(175, 968, true);
            WriteLiteral(@"
<h3>BalimOOn Liqueurs</h3>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h4 class=""card-title"">My Rejected PR</h4>
                </div>
                <div class=""card-body"">
                    <table id=""tabel-5"" class=""table table-primary"">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>PR No.</th>
                                <th>Order Date</th>
                                <th>Due Date</th>
                                <th>Notes</th>
                                <th>Info</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1160, 2972, true);
                WriteLiteral(@" 
    <script>
        $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
        $.fn.dataTable.moment(""DD/MM/YYYY"");
        $(""#tabel-5"").DataTable({
            //Design Layout
            stateSave: true,
            autoWidth: true,
            scrollX: true,

            //ServerSide
            processing: true,
            serverSide: true,

            //Paging Setup
            paging: true,

            //searching Setup
            searching: { regex: true },

            //ajax Filter
            ajax: {
                url: ""/PurchaseRequest/RejectedTable"",
                type: ""POST"",
                contentType: ""application/json"",
                dataType: ""json"",
                data: function (d) {
                    return JSON.stringify(d);
                }
            },
            //column definition
             columnDefs: [
                { targets: ""no-sort"", orderable: false },
                { targets: ""no-search"", searchable: false },
         ");
                WriteLiteral(@"       {
                    targets: ""trim"",
                    render: function (data, type, full, meta) {
                        if (type === ""display"") {
                            data = strtrunc(data, 10);
                        }
                        return data;
                    }
                },
                { targets: ""data-type"", type: ""date-eu"" }
            ],
             //column to display
            columns: [
                { data: ""RequisitionID"", isIdentity: true, visible: false },
                { data: ""RequisitionNo"" },
                {
                    data: ""OrderDate"", render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""ddd, MM/DD/YYYY"");
                        }
                        return data;
                    }
                },
                {
                    data: ""DueDate"", render: function (data, type, row");
                WriteLiteral(@") {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""ddd, MM/DD/YYYY"");
                        }
                        return data;
                    }
                },
                { data: ""RequestNotes"" },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='View(\"""" + full.RequisitionNo + ""\"")' class='btn btn-outline-info btn-block'><span class='fa fa-eye'> </span></a>"";
                    }
                }
            ]
        })
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });
    </script>
<script>
    function View(RequisitionNo) {
        window.location.href = ""/PurchaseRequest/ViewMyRejectDetail?RequisitionNo="" + RequisitionNo;
    }
</script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.PurchaseRequestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591