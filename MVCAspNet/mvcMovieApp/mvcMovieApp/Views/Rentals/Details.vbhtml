@ModelType mvcMovieApp.Rental
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Rental</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DateRented)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateRented)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Customer.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Customer.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Movy.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Movy.Title)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.RentalID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
