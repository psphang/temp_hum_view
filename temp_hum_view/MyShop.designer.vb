﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="MyShop")>  _
Partial Public Class MyShopDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertUserProduct(instance As UserProduct)
    End Sub
  Partial Private Sub UpdateUserProduct(instance As UserProduct)
    End Sub
  Partial Private Sub DeleteUserProduct(instance As UserProduct)
    End Sub
  #End Region
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Products() As System.Data.Linq.Table(Of Product)
		Get
			Return Me.GetTable(Of Product)
		End Get
	End Property
	
	Public ReadOnly Property UserProducts() As System.Data.Linq.Table(Of UserProduct)
		Get
			Return Me.GetTable(Of UserProduct)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Products")>  _
Partial Public Class Product
	
	Private _ProductId As Integer
	
	Private _Name As String
	
	Private _Description As String
	
	Private _Price As Decimal
	
	Private _ProductCode As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductId", AutoSync:=AutoSync.Always, DbType:="Int NOT NULL IDENTITY", IsDbGenerated:=true)>  _
	Public Property ProductId() As Integer
		Get
			Return Me._ProductId
		End Get
		Set
			If ((Me._ProductId = value)  _
						= false) Then
				Me._ProductId = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me._Name = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="VarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Description() As String
		Get
			Return Me._Description
		End Get
		Set
			If (String.Equals(Me._Description, value) = false) Then
				Me._Description = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Price", DbType:="Decimal(18,0) NOT NULL")>  _
	Public Property Price() As Decimal
		Get
			Return Me._Price
		End Get
		Set
			If ((Me._Price = value)  _
						= false) Then
				Me._Price = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductCode", DbType:="VarChar(50)")>  _
	Public Property ProductCode() As String
		Get
			Return Me._ProductCode
		End Get
		Set
			If (String.Equals(Me._ProductCode, value) = false) Then
				Me._ProductCode = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.UserProducts")>  _
Partial Public Class UserProduct
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _UserProductId As Integer
	
	Private _UserName As String
	
	Private _ProductCode As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnUserProductIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnUserProductIdChanged()
    End Sub
    Partial Private Sub OnUserNameChanging(value As String)
    End Sub
    Partial Private Sub OnUserNameChanged()
    End Sub
    Partial Private Sub OnProductCodeChanging(value As String)
    End Sub
    Partial Private Sub OnProductCodeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserProductId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property UserProductId() As Integer
		Get
			Return Me._UserProductId
		End Get
		Set
			If ((Me._UserProductId = value)  _
						= false) Then
				Me.OnUserProductIdChanging(value)
				Me.SendPropertyChanging
				Me._UserProductId = value
				Me.SendPropertyChanged("UserProductId")
				Me.OnUserProductIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property UserName() As String
		Get
			Return Me._UserName
		End Get
		Set
			If (String.Equals(Me._UserName, value) = false) Then
				Me.OnUserNameChanging(value)
				Me.SendPropertyChanging
				Me._UserName = value
				Me.SendPropertyChanged("UserName")
				Me.OnUserNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductCode", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ProductCode() As String
		Get
			Return Me._ProductCode
		End Get
		Set
			If (String.Equals(Me._ProductCode, value) = false) Then
				Me.OnProductCodeChanging(value)
				Me.SendPropertyChanging
				Me._ProductCode = value
				Me.SendPropertyChanged("ProductCode")
				Me.OnProductCodeChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
