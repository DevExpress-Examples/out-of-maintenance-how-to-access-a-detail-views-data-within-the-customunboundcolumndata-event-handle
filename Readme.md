<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624995/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2442)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E2442_UnboundDataFromDetail/Form1.cs) (VB: [Form1.vb](./VB/E2442_UnboundDataFromDetail/Form1.vb))
<!-- default file list end -->
# How to access a detail view's data within the CustomUnboundColumnData event handler


<p>Here we have created a grid control with a master-detail view completely at runtime. An unbound column in the master view calculates its values based on data from the detail views. All calculations take place in the CustomUnboundColumnData event handler. Generally you should use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_GetDetailViewtopic">GetDetalView</a> method to obtain detail view data. But, if you work with detail data within the master view's  CustomUnboundColumnData event handler you shouldn't use this way, because CustomUnboundColumnData event can be raised when detail view is being painted or even isn't yet created. So, this example shows how to obtain detail data directly from the data controller and check if it is filtered.</p>

<br/>


