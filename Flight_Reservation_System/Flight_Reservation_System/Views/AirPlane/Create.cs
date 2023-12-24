@model Flight_Reservation_System.Models.AirPlane

@{
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h1>Create</h1>

<h4>AirPlane</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form asp-action="Create">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="PlaneName" class="control-label"></label>
                <input asp-for="PlaneName" class="form-control" />
                <span asp-validation-for="PlaneName" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Capacity" class="control-label"></label>
                <input asp-for="Capacity" class="form-control" />
                <span asp-validation-for="Capacity" class="text-danger"></span>
            </div>
            <div class="form-group">
                <input type="submit" value="add Plane" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action="Index">All Planes</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
