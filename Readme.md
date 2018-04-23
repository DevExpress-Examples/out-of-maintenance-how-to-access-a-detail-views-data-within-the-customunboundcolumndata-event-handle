# How to access a detail view's data within the CustomUnboundColumnData event handler


<p>Here we have created a grid control with a master-detail view completely at runtime. An unbound column in the master view calculates its values based on data from the detail views. All calculations take place in the CustomUnboundColumnData event handler. Generally you should use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_GetDetailViewtopic">GetDetalView</a> method to obtain detail view data. But, if you work with detail data within the master view's  CustomUnboundColumnData event handler you shouldn't use this way, because CustomUnboundColumnData event can be raised when detail view is being painted or even isn't yet created. So, this example shows how to obtain detail data directly from the data controller and check if it is filtered.</p>

<br/>


