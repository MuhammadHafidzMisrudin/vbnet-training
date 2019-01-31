Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports mvcMovieApp

Namespace Controllers
    Public Class RentalsController
        Inherits System.Web.Mvc.Controller

        Private db As New MoviesDBEntities

        ' GET: Rentals
        Function Index() As ActionResult
            Dim rentals = db.Rentals.Include(Function(r) r.Customer).Include(Function(r) r.Movy)
            Return View(rentals.ToList())
        End Function

        ' GET: Rentals/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rental As Rental = db.Rentals.Find(id)
            If IsNothing(rental) Then
                Return HttpNotFound()
            End If
            Return View(rental)
        End Function

        ' GET: Rentals/Create
        Function Create() As ActionResult
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "FirstName")
            ViewBag.MovieID = New SelectList(db.Movies, "MovieID", "Title")
            Return View()
        End Function

        ' POST: Rentals/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="RentalID,CustomerID,MovieID,DateRented")> ByVal rental As Rental) As ActionResult
            If ModelState.IsValid Then
                db.Rentals.Add(rental)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "FirstName", rental.CustomerID)
            ViewBag.MovieID = New SelectList(db.Movies, "MovieID", "Title", rental.MovieID)
            Return View(rental)
        End Function

        ' GET: Rentals/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rental As Rental = db.Rentals.Find(id)
            If IsNothing(rental) Then
                Return HttpNotFound()
            End If
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "FirstName", rental.CustomerID)
            ViewBag.MovieID = New SelectList(db.Movies, "MovieID", "Title", rental.MovieID)
            Return View(rental)
        End Function

        ' POST: Rentals/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="RentalID,CustomerID,MovieID,DateRented")> ByVal rental As Rental) As ActionResult
            If ModelState.IsValid Then
                db.Entry(rental).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CustomerID = New SelectList(db.Customers, "CustomerID", "FirstName", rental.CustomerID)
            ViewBag.MovieID = New SelectList(db.Movies, "MovieID", "Title", rental.MovieID)
            Return View(rental)
        End Function

        ' GET: Rentals/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rental As Rental = db.Rentals.Find(id)
            If IsNothing(rental) Then
                Return HttpNotFound()
            End If
            Return View(rental)
        End Function

        ' POST: Rentals/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim rental As Rental = db.Rentals.Find(id)
            db.Rentals.Remove(rental)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
