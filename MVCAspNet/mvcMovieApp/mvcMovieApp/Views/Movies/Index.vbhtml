@ModelType IEnumerable(Of mvcMovieApp.Movy)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DirectorName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Genre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DirectorName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Genre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MovieID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MovieID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MovieID })
        </td>
    </tr>
Next

</table>
