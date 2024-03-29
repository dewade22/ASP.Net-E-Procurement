#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f431b700bbdb8507c1324c8b854e2be7f65c19b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMLPurchaseOrder_Closed), @"mvc.1.0.view", @"/Views/BMLPurchaseOrder/Closed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BMLPurchaseOrder/Closed.cshtml", typeof(AspNetCore.Views_BMLPurchaseOrder_Closed))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f431b700bbdb8507c1324c8b854e2be7f65c19b8", @"/Views/BMLPurchaseOrder/Closed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca815501e2415492be7fd7738acfe7eb9493282", @"/Views/_ViewImports.cshtml")]
    public class Views_BMLPurchaseOrder_Closed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLPurchaseOrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
  
    ViewData["Title"] = "Open";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 1131, true);
            WriteLiteral(@"
<br />
<h2>Balim00n Liqueurs</h2>
<section class=""content"">
    <div class=""card"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Purchase Order - Closed</h3>
                </div>
                <div class=""card-body"">
                    <table id=""tabel5"" class=""table table-striped table-bordered"">
                        <thead>
                            <tr>
                                <th>PO ID</th>
                                <th>PO Number</th>
                                <th>Item Description</th>
                                <th>Vendor</th>
                                <th>Order Date</th>
                                <th>Expected Received Date</th>
                                <th>Amount</th>
                                <th>Details</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
       ");
            WriteLiteral("             </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1314, 8410, true);
                WriteLiteral(@"
    <script>
        $.fn.dataTable.moment(""DD/MM/YYYY HH:mm:ss"");
        $.fn.dataTable.moment(""DD/MM/YYYY"");
        //datatable pada index
        $(""#tabel5"").DataTable({
            //Design Layout
            stateSave: true,
            autoWidth: true,

            //ServerSide
            processing: true,
            serverSide: true,

            //Paging Setup
            paging: true,

            //searching Setup
            searching: { regex: true },

            //ajax Filter
            ajax: {
                url: ""/BMLPurchaseOrder/GetBMLPOListCL"",
                //""dataSrc"": '',
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
                { targets: ""no-s");
                WriteLiteral(@"earch"", searchable: false },
                {
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

            columns: [
                { data: ""PurchaseHeaderId"", isIdentity: true, visible: false, searchable: false },
                { data: ""No"" },
                { data: ""Description"" },
                { data: ""BuyfromVendorName"" },
                {
                    data: ""OrderDate"", render: function (data, type, row) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
");
                WriteLiteral(@"                },
                {
                    data: ""ExpectedReceiptDate"", render: function (data, type) {
                        if (type === ""display"" || type === ""filter"") {
                            return moment(data).format(""dddd, DD-MM-YYYY"");
                        }
                        return data;
                    }
                },
                { data: ""Amount"", render: $.fn.dataTable.render.number(',', '.', 2) },
                {
                    render: function (data, type, full, meta) {
                        return ""<a href='#' onclick='POOpenDetails(\"""" + full.PurchaseHeaderId + ""\"")' class='btn btn-outline-info'><span class='pe-7s-info'> Details</span></a>"";
                    }
                }

            ]
        })
        $("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
        $("".table "").css({ ""width"": ""100%"" });

        //show detail PR to PopUp Modal Dialog
        function POOpenDetails(PurchaseHeaderId) {
     ");
                WriteLiteral(@"       var url = ""/BMLPurchaseOrder/GetPO?PurchaseHeaderId="" + PurchaseHeaderId;
            $(""#exampleModalLongTitle"").html(""PO - Closed"");
            $(""#MyLargeModal"").modal();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    var obj = JSON.parse(data);
                    $(""#PurchaseHeaderId"").val(obj.PurchaseHeaderId);
                    $(""#DocumentNo"").val(obj.DocumentNo);
                    $(""#CreatedBy"").val(obj.CreatedBy);
                    $(""#DimensionValue"").val(obj.DimensionValue);
                    $(""#OrderDate"").val(obj.OrderDate);
                    $(""#ExpectedReceiptDate"").val(obj.ExpectedReceiptDate);
                    $(""#VendorName"").val(obj.VendorName);
                    $(""#Amount"").val(obj.Amount);
                    $(""#AmountIncludingVAT"").val(obj.AmountIncludingVAT);
                }
            })
            //Get PO Line
            $(""#tabel6"").DataTab");
                WriteLiteral(@"le({
            //Design Layout
                stateSave: true,
                autoWidth: true,


            //ServerSide
                processing: true,
                serverSide: true,

            //Paging Setup
                paging: true,

            //searching Setup
                searching: { regex: true },

            //ajax Filter
                ajax: {
                    url: ""/BMLPurchaseOrder/GetPODetails?PurchaseHeaderId="" +PurchaseHeaderId,
                    //""dataSrc"": '',
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
                    {
            ");
                WriteLiteral(@"            targets: ""trim"",
                        render: function (data, type, full, meta) {
                            if (type === ""display"") {
                                data = strtrunc(data, 10);
                            }
                            return data;
                        }
                    },
                    { targets: ""data-type"", type: ""date-eu"" }
                ],

                columns: [
                    { data: ""PurchaseLineId"", isIdentity: true, searchable: false, visible: false },
                    { data: ""Description"" },
                    { data: ""VendorName"" },
                    { data: ""Quantity"" },
                    { data: ""QuantityReceive"" },
                    { data: ""Currency"" },
                    { data: ""Amount"", render: $.fn.dataTable.render.number(',', '.', 2)},
                    { data: ""AmountVAT"", render: $.fn.dataTable.render.number(',', '.', 2)}
                ],
                footerCallback: function");
                WriteLiteral(@" (row, data, start, end, display) {
                    var api = this.api(), data;
                    var numFormat = $.fn.dataTable.render.number( '\,', '.', 2 ).display;
                    //Get Integer Data
                    var intVal = function (i) {
                        return typeof i === 'string' ?
                            i.replace(/[\$,]/g, '') * 1 :
                            typeof i === 'number' ?
                                i : 0;
                    };
                    //Sum All Pages

                    totalQty = api
                        .column(3)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);

                    total = api
                        .column(6)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        },");
                WriteLiteral(@" 0);
                     totalVAT = api
                        .column(7)
                        .data()
                        .reduce(function (a, b) {
                            return intVal(a) + intVal(b);
                        }, 0);
                    // Update footer 1
                    $(api.column(3).footer()).html(
                        numFormat(totalQty)
                    );

                     $(api.column(6).footer()).html(
                        numFormat(total)
                    );
                    $( api.column(7).footer() ).html(
                        numFormat(totalVAT)
                    );
                }
            })
            $("".dataTables_scrollHeadInner"").css({""width"":""100%""});
            $("".table "").css({""width"":""100%""});
        }

         //on close event
        $('#MyLargeModal').on('hidden.bs.modal', function () {
        $('#tabel6').dataTable().fnDestroy();
        $(this)
            .find(""input[type=text],input");
                WriteLiteral("[type=email],textarea,select\")\r\n            .val(\'\')\r\n            .end()\r\n            .find(\"input[type=checkbox], input[type=radio]\")\r\n            .prop(\"checked\", \"\")\r\n            .end();\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(9727, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(9745, 444, true);
                WriteLiteral(@"
    <div class=""modal fade bd-example-modal-lg"" id=""MyLargeModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""exampleModalLongTitle""></h4>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(10189, 5230, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f431b700bbdb8507c1324c8b854e2be7f65c19b815062", async() => {
                    BeginContext(10205, 82, true);
                    WriteLiteral("\r\n                        <fieldset id=\"SubmitForm\">\r\n                            ");
                    EndContext();
                    BeginContext(10288, 89, false);
#line 267 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                       Write(Html.HiddenFor(a => a.purchasesHeader.PurchaseHeaderId, new { @id = "PurchaseHeaderId" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10377, 208, true);
                    WriteLiteral("\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>PO Number</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10586, 125, false);
#line 271 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesLine.DocumentNo, new { @id = "DocumentNo", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(10711, 196, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>PR Number</label>\r\n                                    ");
                    EndContext();
                    BeginContext(10908, 119, false);
#line 275 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesLine.RefPrno, new { @id = "RefPrno", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11027, 288, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>PO Created by</label>
                                    ");
                    EndContext();
                    BeginContext(11316, 125, false);
#line 281 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.CreatedBy, new { @id = "CreatedBy", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11441, 195, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Location</label>\r\n                                    ");
                    EndContext();
                    BeginContext(11637, 141, false);
#line 285 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesLine.ShortcutDimension1Code, new { @id = "DimensionValue", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(11778, 285, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <label>Order Date</label>
                                    ");
                    EndContext();
                    BeginContext(12064, 151, false);
#line 291 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.OrderDate, new { @id = "OrderDate", @class = "form-control", @readonly = "readonly", @Type = "datetime-local" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12215, 208, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Expected Receive Date</label>\r\n                                    ");
                    EndContext();
                    BeginContext(12424, 171, false);
#line 295 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.ExpectedReceiptDate, new { @id = "ExpectedReceiptDate", @class = "form-control", @readonly = "readonly", @Type = "datetime-local" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12595, 224, true);
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Vendor Name</label>\r\n                                ");
                    EndContext();
                    BeginContext(12820, 126, false);
#line 300 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                           Write(Html.TextBoxFor(a => a.purchasesHeader.PaytoName, new { @id = "VendorName", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(12946, 241, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Amount</label>\r\n                                    ");
                    EndContext();
                    BeginContext(13188, 119, false);
#line 305 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.Amount, new { @id = "Amount", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13307, 205, true);
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <label>Amount Include VAT</label>\r\n                                    ");
                    EndContext();
                    BeginContext(13513, 143, false);
#line 309 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Views\BMLPurchaseOrder\Closed.cshtml"
                               Write(Html.TextBoxFor(a => a.purchasesHeader.AmountIncludingVat, new { @id = "AmountIncludingVAT", @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(13656, 1756, true);
                    WriteLiteral(@"
                                </div>
                            </div>
                            <div><br /></div>
                            <div class=""form-group"">
                                <table id=""tabel6"" class=""table table-striped"">
                                    <thead>
                                        <tr>
                                            <th>PurchaseLineId</th>
                                            <th>Item Name</th>
                                            <th>Vendor</th>
                                            <th>Qty</th>
                                            <th>Qty Receive</th>
                                            <th>Currency</th>
                                            <th>Amount</th>
                                            <th>Amount Incl VAT</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
               ");
                    WriteLiteral(@"                     <tfoot>
                                        <tr>
                                            <th colspan=""2"" style=""text-align:right"">Total:</th>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </fieldset>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15419, 247, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balimoon_E_Procurement.Models.BalimoonBML.ViewModel.BMLPurchaseOrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
