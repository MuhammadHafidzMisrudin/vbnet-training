﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports mvcMovieApp

Namespace Controllers
    Public Class MoviesController
        Inherits System.Web.Mvc.Controller

        Private db As New MoviesDBEntities

        ' GET: Movies
        Function Index() As ActionResult
            Return View(db.Movies.ToList())
        End Function

        ' GET: Movies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movy As Movy = db.Movies.Find(id)
            If IsNothing(movy) Then
                Return HttpNotFound()
            End If
            Return View(movy)
        End Function

        ' GET: Movies/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Movies/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MovieID,Title,DirectorName,Genre")> ByVal movy As Movy) As ActionResult
            If ModelState.IsValid Then
                db.Movies.Add(movy)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(movy)
        End Function

        ' GET: Movies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movy As Movy = db.Movies.Find(id)
            If IsNothing(movy) Then
                Return HttpNotFound()
            End If
            Return View(movy)
        End Function

        ' POST: Movies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MovieID,Title,DirectorName,Genre")> ByVal movy As Movy) As ActionResult
            If ModelState.IsValid Then
                db.Entry(movy).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(movy)
        End Function

        ' GET: Movies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movy As Movy = db.Movies.Find(id)
            If IsNothing(movy) Then
                Return HttpNotFound()
            End If
            Return View(movy)
        End Function

        ' POST: Movies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim movy As Movy = db.Movies.Find(id)
            db.Movies.Remove(movy)
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
