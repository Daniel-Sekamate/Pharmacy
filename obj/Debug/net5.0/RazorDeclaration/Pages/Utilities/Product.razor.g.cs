// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Pharmacy.Pages.Utilities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CoreProjects\Pharmacy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Pharmacy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Pharmacy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CoreProjects\Pharmacy\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CoreProjects\Pharmacy\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using Pharmacy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
using Pharmacy.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Utilities/Product")]
    public partial class Product : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 321 "D:\CoreProjects\Pharmacy\Pages\Utilities\Product.razor"
       
    #region Toasters
    public static string ToastContent { get; set; }
    SfToast ToastObj;
    SfToast DeleteToastObj;
    private string ToastPosition = "Right";
    private int AlarmTimeout { get; set; } = 120000;
    private List<ToastModel> Toast = new List<ToastModel>
{
        new ToastModel{ Title = "Warning!", Content=ToastContent, CssClass="e-toast-warning", Icon="e-warning toast-icons" },
        new ToastModel{ Title = "Success!", Content=ToastContent, CssClass="e-toast-success", Icon="e-success toast-icons" },
        new ToastModel{ Title = "Error!", Content=ToastContent, CssClass="e-toast-danger", Icon="e-error toast-icons" },
        new ToastModel{ Title = "Information!", Content=ToastContent, CssClass="e-toast-info", Icon="e-info toast-icons" }
    };
    #endregion Toasters

    private SfGrid<Aproduct> ProductGrid;
    private SfGrid<AproductCategory> ProductCategoryGrid;
    private SfGrid<AproductClassification> ProductClassificationGrid;
    private SfGrid<AproductSupplier> ProductSupplierGrid;
    private List<AproductCategory> _ProductCategory { get; set; }

    private List<AbasicUnit> BasicUnit { get; set; }
    private List<AproductCategory> ProductCategory { get; set; }
    private List<AproductSupplier> ProductSupplier { get; set; }
    private List<AproductClassification> productClassification { get; set; }
    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (!userManagement.IsSignedIn())
            {
                Navigation.NavigateTo("Account/LoginPage", true);
            }
            _ProductCategory = _context.AproductCategories.ToList();
            BasicUnit = _context.AbasicUnits.ToList();
            ProductSupplier = _context.AproductSuppliers.ToList();
            ProductCategory = _context.AproductCategories.ToList();
            productClassification = _context.AproductClassifications.ToList();
        }
        catch (Exception ex)
        {
            await ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }
    }

    #region Product Category DataSource
    public class ProductCategoryAdapter : DataAdaptor
    {
        public IToastService toastService;
        public ProductCategoryAdapter(IToastService ts)
        {
            toastService = ts;
        }
        public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            var data = new List<AproductCategory>();
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    data = await dbContext.AproductCategories.OrderBy(o => o.CategoryDescription).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            IEnumerable GridData = data;
            int _count = data.Count;
            if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
            {
                // Searching
                GridData = DataOperations.PerformSearching(GridData, dataManagerRequest.Search);
            }
            if (dataManagerRequest.Sorted?.Count > 0) // perform Sorting
            {
                GridData = DataOperations.PerformSorting(GridData, dataManagerRequest.Sorted);
            }
            if (dataManagerRequest.Skip != 0)
            {
                GridData = DataOperations.PerformSkip(GridData, dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                GridData = DataOperations.PerformTake(GridData, dataManagerRequest.Take);
            }
            IDictionary<string, object> aggregates = new Dictionary<string, object>();
            if (dataManagerRequest.Aggregates != null) // Aggregation
            {
                aggregates = DataUtil.PerformAggregation(GridData, dataManagerRequest.Aggregates);
            }
            if (dataManagerRequest.Group != null && dataManagerRequest.Group.Any()) //Grouping
            {
                foreach (var group in dataManagerRequest.Group)
                {
                    GridData = DataUtil.Group<AproductCategory>(GridData, group, dataManagerRequest.Aggregates, 0, dataManagerRequest.GroupByFormatter);
                }
            }
            return dataManagerRequest.RequiresCounts ? new DataResult() { Result = GridData, Count = _count, Aggregates = aggregates } : (object)GridData;
        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductCategory);
                    int id = 1;
                    var data = dbContext.AproductCategories.ToList().LastOrDefault();
                    if (data != null)
                    {
                        id = (data.CategoryId + 1);
                    }
                    AproductCategory order = new AproductCategory();
                    order.CategoryId = id;
                    order.CategoryDescription = val.CategoryDescription;
                    dbContext.AproductCategories.Add(order);
                    await dbContext.SaveChangesAsync();
                    toastService.ShowSuccess(val.CategoryDescription + " has been saved successfully.");
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                int data = (int)value;
                var val = (value as AproductCategory);
                using (var dbContext = new SPToCoreContext())
                {
                    // dbContext.AphysicalCount.Remove(dbContext.AphysicalCount.FirstOrDefault(o => o.PhysicalCountId == val.PhysicalCountId));
                    // await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }


            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductCategory);
                    var exist = dbContext.AproductCategories.FirstOrDefault(o => o.CategoryId == val.CategoryId);
                    if (exist != null)
                    {
                        exist.CategoryDescription = val.CategoryDescription;

                        dbContext.Entry(exist).State = EntityState.Modified;
                        await dbContext.SaveChangesAsync();
                        toastService.ShowSuccess(val.CategoryDescription + " has been updated successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            return value;
        }
    }
    public void OnProductCategoryActionBegin(ActionEventArgs<AproductCategory> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {

        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {

        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {

        }
        //if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        //{
        //    this.OrderGrid.EndEdit();
        //}
    }
    #endregion Product Category DataSource
    #region Product Classification DataSource
    public class ProductClassificationAdapter : DataAdaptor
    {
        public IToastService toastService;
        public ProductClassificationAdapter(IToastService ts)
        {
            toastService = ts;
        }
        public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            var data = new List<AproductClassification>();
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    data = await dbContext.AproductClassifications.OrderBy(o => o.ClassificationDesc).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            IEnumerable GridData = data;
            int _count = data.Count;
            if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
            {
                // Searching
                GridData = DataOperations.PerformSearching(GridData, dataManagerRequest.Search);
            }
            if (dataManagerRequest.Sorted?.Count > 0) // perform Sorting
            {
                GridData = DataOperations.PerformSorting(GridData, dataManagerRequest.Sorted);
            }
            if (dataManagerRequest.Skip != 0)
            {
                GridData = DataOperations.PerformSkip(GridData, dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                GridData = DataOperations.PerformTake(GridData, dataManagerRequest.Take);
            }
            IDictionary<string, object> aggregates = new Dictionary<string, object>();
            if (dataManagerRequest.Aggregates != null) // Aggregation
            {
                aggregates = DataUtil.PerformAggregation(GridData, dataManagerRequest.Aggregates);
            }
            if (dataManagerRequest.Group != null && dataManagerRequest.Group.Any()) //Grouping
            {
                foreach (var group in dataManagerRequest.Group)
                {
                    GridData = DataUtil.Group<AproductClassification>(GridData, group, dataManagerRequest.Aggregates, 0, dataManagerRequest.GroupByFormatter);
                }
            }
            return dataManagerRequest.RequiresCounts ? new DataResult() { Result = GridData, Count = _count, Aggregates = aggregates } : (object)GridData;
        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductClassification);
                    int id = 1;
                    var data = dbContext.AproductClassifications.ToList().LastOrDefault();
                    if (data != null)
                    {
                        id = (data.ClassificationId + 1);
                    }
                    val.ClassificationId = id;
                    dbContext.AproductClassifications.Add(val);
                    await dbContext.SaveChangesAsync();
                    toastService.ShowSuccess(val.ClassificationDesc + " has been saved successfully.");
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                int data = (int)value;
                var val = (value as AproductClassification);
                //using (var dbContext = new SPToCoreContext())
                //{
                //    dbContext.AphysicalCount.Remove(dbContext.AphysicalCount.FirstOrDefault(o => o.PhysicalCountId == val.PhysicalCountId));
                //    await dbContext.SaveChangesAsync();
                //}
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }


            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductClassification);
                    var exist = dbContext.AproductClassifications.FirstOrDefault(o => o.ClassificationId == val.ClassificationId);
                    if (exist != null)
                    {
                        exist.ProductCategoryId = val.ProductCategoryId;
                        exist.ClassificationDesc = val.ClassificationDesc;

                        dbContext.Entry(exist).State = EntityState.Modified;
                        await dbContext.SaveChangesAsync();
                        toastService.ShowSuccess(val.ClassificationDesc + " has been updated successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            return value;
        }
    }
    public void OnProductClassificationActionBegin(ActionEventArgs<AproductClassification> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {
            _ProductCategory = _context.AproductCategories.ToList();
        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            _ProductCategory = _context.AproductCategories.ToList();
        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {

        }
        //if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        //{
        //    this.OrderGrid.EndEdit();
        //}
    }
    #endregion Product Classification DataSource
    #region Supplier DataSource
    public class SupplierAdapter : DataAdaptor
    {
        public IToastService toastService;
        public SupplierAdapter(IToastService ts)
        {
            toastService = ts;
        }
        public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            var data = new List<AproductSupplier>();
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    data = await dbContext.AproductSuppliers.OrderBy(o => o.SupplierDescription).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            IEnumerable GridData = data;
            int _count = data.Count;
            if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
            {
                // Searching
                GridData = DataOperations.PerformSearching(GridData, dataManagerRequest.Search);
            }
            if (dataManagerRequest.Sorted?.Count > 0) // perform Sorting
            {
                GridData = DataOperations.PerformSorting(GridData, dataManagerRequest.Sorted);
            }
            if (dataManagerRequest.Skip != 0)
            {
                GridData = DataOperations.PerformSkip(GridData, dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                GridData = DataOperations.PerformTake(GridData, dataManagerRequest.Take);
            }
            IDictionary<string, object> aggregates = new Dictionary<string, object>();
            if (dataManagerRequest.Aggregates != null) // Aggregation
            {
                aggregates = DataUtil.PerformAggregation(GridData, dataManagerRequest.Aggregates);
            }
            if (dataManagerRequest.Group != null && dataManagerRequest.Group.Any()) //Grouping
            {
                foreach (var group in dataManagerRequest.Group)
                {
                    GridData = DataUtil.Group<AproductSupplier>(GridData, group, dataManagerRequest.Aggregates, 0, dataManagerRequest.GroupByFormatter);
                }
            }
            return dataManagerRequest.RequiresCounts ? new DataResult() { Result = GridData, Count = _count, Aggregates = aggregates } : (object)GridData;
        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductSupplier);
                    int id = 1;
                    var data = dbContext.AproductSuppliers.ToList().LastOrDefault();
                    if (data != null)
                    {
                        id = (data.SupplierId + 1);
                    }
                    val.SupplierId = id;
                    dbContext.AproductSuppliers.Add(val);
                    await dbContext.SaveChangesAsync();
                    toastService.ShowSuccess(val.SupplierDescription + " has been saved successfully.");
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                int data = (int)value;
                var val = (value as AproductSupplier);
                //using (var dbContext = new SPToCoreContext())
                //{
                //    dbContext.AphysicalCount.Remove(dbContext.AphysicalCount.FirstOrDefault(o => o.PhysicalCountId == val.PhysicalCountId));
                //    await dbContext.SaveChangesAsync();
                //}
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }


            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as AproductSupplier);
                    var exist = dbContext.AproductSuppliers.FirstOrDefault(o => o.SupplierId == val.SupplierId);
                    if (exist != null)
                    {
                        exist.SupplierDescription = val.SupplierDescription;
                        exist.Email = val.Email;
                        exist.Phone = val.Phone;
                        exist.Pobox = val.Pobox;
                        exist.Fax = val.Fax;
                        exist.City = val.City;
                        exist.Street = val.Street;
                        exist.Country = val.Country;

                        dbContext.Entry(exist).State = EntityState.Modified;
                        await dbContext.SaveChangesAsync();
                        toastService.ShowSuccess(val.SupplierDescription + " has been updated successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }

            return value;
        }
    }
    public void OnSupplierActionBegin(ActionEventArgs<AproductSupplier> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {

        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {

        }
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {

        }
        //if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        //{
        //    this.OrderGrid.EndEdit();
        //}
    }
    #endregion Supplier DataSource
    #region Aproducts DataSource
    public class ProductAdapter : DataAdaptor
    {
        public IToastService toastService;
        public ProductAdapter(IToastService ts)
        {
            toastService = ts;
        }
        public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            try
            {
                var data = new List<Aproduct>();
                using (var dbContext = new SPToCoreContext())
                {
                    data = await dbContext.Aproducts.ToListAsync();
                }
                IEnumerable GridData = data;
                int _count = data.Count;
                if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
                {
                    // Searching
                    GridData = DataOperations.PerformSearching(GridData, dataManagerRequest.Search);
                }
                if (dataManagerRequest.Sorted?.Count > 0) // perform Sorting
                {
                    GridData = DataOperations.PerformSorting(GridData, dataManagerRequest.Sorted);
                }
                if (dataManagerRequest.Skip != 0)
                {
                    GridData = DataOperations.PerformSkip(GridData, dataManagerRequest.Skip); //Paging
                }
                if (dataManagerRequest.Take != 0)
                {
                    GridData = DataOperations.PerformTake(GridData, dataManagerRequest.Take);
                }
                IDictionary<string, object> aggregates = new Dictionary<string, object>();
                if (dataManagerRequest.Aggregates != null) // Aggregation
                {
                    aggregates = DataUtil.PerformAggregation(GridData, dataManagerRequest.Aggregates);
                }
                if (dataManagerRequest.Group != null && dataManagerRequest.Group.Any()) //Grouping
                {
                    foreach (var group in dataManagerRequest.Group)
                    {
                        GridData = DataUtil.Group<Aproduct>(GridData, group, dataManagerRequest.Aggregates, 0, dataManagerRequest.GroupByFormatter);
                    }
                }
                return dataManagerRequest.RequiresCounts ? new DataResult() { Result = GridData, Count = _count, Aggregates = aggregates } : (object)GridData;
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
                return null;
            }
        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as Aproduct);
                    var exist = dbContext.Aproducts.FirstOrDefault(o => o.ProductCode == val.ProductCode);
                    if (exist != null)
                    {
                        //exist.ProductCode =val.ProductCode;
                        exist.ProductDescription = val.ProductDescription;
                        exist.CategoryId = val.CategoryId;
                        exist.SupplierId = val.SupplierId;
                        exist.BasicUnitId = val.BasicUnitId;
                        exist.PackSize = val.PackSize;
                        exist.ListPrice = val.ListPrice;
                        exist.RetailPrice = val.RetailPrice;
                        exist.ProductClassificationId = val.ProductClassificationId;

                        dbContext.Entry(exist).State = EntityState.Modified;
                    }
                    else
                    {
                        double id = 1;
                        var data = dbContext.Aproducts.ToList().LastOrDefault();
                        if (data != null)
                        {
                            id = (data.ProductCode + 1);
                        }
                        Aproduct order = new Aproduct();
                        order.ProductCode = id;
                        order.ProductDescription = val.ProductDescription;
                        order.CategoryId = val.CategoryId;
                        order.SupplierId = val.SupplierId;
                        order.BasicUnitId = val.BasicUnitId;
                        order.PackSize = val.PackSize;
                        order.ListPrice = val.ListPrice;
                        order.RetailPrice = val.RetailPrice;
                        order.ProductClassificationId = val.ProductClassificationId;
                        dbContext.Aproducts.Add(order);
                    }
                    await dbContext.SaveChangesAsync();
                    string result = "Product " + val.ProductDescription + " has been added successfully";
                    toastService.ShowSuccess(result);
                }

            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            //int data = (int)value;
            //var val = (value as Aproduct);
            //using (var dbContext = new SPToCoreContext())
            //{
            //    dbContext.Aproduct.Remove(dbContext.Aproduct.FirstOrDefault(o => o.FacilityCode == val.FacilityCode && o.ProductCode == val.ProductCode && o.BatchNo == val.BatchNo && o.DateOfPhysicalCount == val.DateOfPhysicalCount));
            //    await dbContext.SaveChangesAsync();
            //}

            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {
            try
            {
                using (var dbContext = new SPToCoreContext())
                {
                    var val = (value as Aproduct);
                    var exist = dbContext.Aproducts.FirstOrDefault(o => o.ProductCode == val.ProductCode);
                    if (exist != null)
                    {
                        //exist.ProductCode =val.ProductCode;
                        exist.ProductDescription = val.ProductDescription;
                        exist.CategoryId = val.CategoryId;
                        exist.SupplierId = val.SupplierId;
                        exist.BasicUnitId = val.BasicUnitId;
                        exist.PackSize = val.PackSize;
                        exist.ListPrice = val.ListPrice;
                        exist.RetailPrice = val.RetailPrice;
                        exist.ProductClassificationId = val.ProductClassificationId;

                        dbContext.Entry(exist).State = EntityState.Modified;
                        await dbContext.SaveChangesAsync();
                    }
                    string result = "Product " + exist.ProductDescription + " has been updated successfully";
                    toastService.ShowSuccess(result);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.ToString());
            }
            return value;
        }
    }
    public async void OnActionBegin(ActionEventArgs<Aproduct> args)
    {
        try
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
            {
                BasicUnit = _context.AbasicUnits.ToList();
                ProductSupplier = _context.AproductSuppliers.ToList();
                ProductCategory = _context.AproductCategories.ToList();
                productClassification = _context.AproductClassifications.ToList();
            }
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
            {
                BasicUnit = _context.AbasicUnits.ToList();
                ProductSupplier = _context.AproductSuppliers.ToList();
                ProductCategory = _context.AproductCategories.ToList();
                productClassification = _context.AproductClassifications.ToList();
            }
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
            {

            }
        }
        catch (Exception ex)
        {
            await ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }

    }
    public void OnComplaintClassificationChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, AproductClassification> args)
    {
        int val = Convert.ToInt32(args.Value);
        if (val == 2)
        {

        }
        else
        {

        }
    }
    #endregion Aproducts DataSource

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManagement userManagement { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PharmacyContext _context { get; set; }
    }
}
#pragma warning restore 1591
