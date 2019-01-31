@ModelType mvcMovieApp.Movy
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Movy</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DirectorName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DirectorName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Genre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Genre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.MovieID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
