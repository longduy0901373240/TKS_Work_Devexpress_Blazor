using Entity.DX;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Web.Pages.DX
{
    public partial class Maps
    {
        List<CDX_Trip> p_arrTrip;
        CDX_Trip EditContext = null;
        protected override async Task OnInitializedAsync()
        {
            p_arrTrip = await _db_Trip.List_DX_Trip();
            SelectedTripChanged(EditContext);

        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await IJS.InvokeVoidAsync("initMap", null);
            }
        }
        void SelectedTripChanged(CDX_Trip p_objItem)
        {
            CDX_Giao_Hang v_objGiao_Hang = new CDX_Giao_Hang();
            CDX_Nhan_Hang v_objNhan_Hang = new CDX_Nhan_Hang();
            if (p_objItem != null)
            {
                EditContext = p_objItem;
                v_objGiao_Hang = _db_Giao_Hang.Get_DX_Giao_Hang_By_ID(EditContext.Giao_Hang_ID);
                v_objNhan_Hang = _db_Nhan_Hang.Get_DX_Nhan_Hang_By_ID(EditContext.Nhan_Hang_ID);
                IJS.InvokeVoidAsync(identifier: "point_Giao_Nhan", v_objGiao_Hang, v_objNhan_Hang);
            }   
        }
    }
}
