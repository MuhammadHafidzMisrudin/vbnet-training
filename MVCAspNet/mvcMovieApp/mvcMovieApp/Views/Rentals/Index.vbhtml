@ModelType IEnumerable(Of mvcMovieApp.Rental)
@Code
ViewData("Title") = "Index"
End Code

<h2>Movie Rentals</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateRented)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customer.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customer.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customer.Phone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customer.Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Movy.Title)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateRented)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customer.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customer.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customer.Phone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customer.Email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Movy.Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.RentalID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.RentalID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.RentalID })
        </td>
    </tr>
Next

</table>
