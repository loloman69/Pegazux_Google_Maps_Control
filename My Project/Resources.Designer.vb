﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.1
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o vuelva a generar su proyecto de VS.
    '''<summary>
    '''  Clase de recurso con establecimiento inflexible de tipos, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso con establecimiento inflexible de tipos.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property document_resize() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("document_resize", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property document_resize_actual() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("document_resize_actual", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a 
        '''
        '''// GENERAL FUNCTIONS
        '''
        '''function CastToJsLatLng(item) {
        '''    if (item != null) {
        '''        return new google.maps.LatLng(item.lat, item.lng, item.NoWrap);
        '''    }
        '''    else {
        '''        return null;
        '''    };    
        '''};
        '''
        '''function CastToJsSize(item) {
        '''    if (item != null) {
        '''        return new google.maps.Size(item.width, item.height, item.widthUnit, item.heightUnit);
        '''    }
        '''    else {
        '''        return null;        
        '''    };        
        '''};
        '''
        '''function CastToJsPoint(item) {
        '''    if (item != null) {
        '''        return [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property functions() As String
            Get
                Return ResourceManager.GetString("functions", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property gear() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("gear", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property image_export() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("image_export", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property image_resize() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("image_resize", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property image_resize_actual() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("image_resize_actual", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a /*!
        '''* jQuery JavaScript Library v1.5.2
        '''* http://jquery.com/
        '''*
        '''* Copyright 2011, John Resig
        '''* Dual licensed under the MIT or GPL Version 2 licenses.
        '''* http://jquery.org/license
        '''*
        '''* Includes Sizzle.js
        '''* http://sizzlejs.com/
        '''* Copyright 2011, The Dojo Foundation
        '''* Released under the MIT, BSD, and GPL Licenses.
        '''*
        '''* Date: Thu Mar 31 15:28:23 2011 -0400
        '''*/
        '''(function (a, b) { function ci(a) { return d.isWindow(a) ? a : a.nodeType === 9 ? a.defaultView || a.parentWindow : !1 } function cf(a) { if (!b [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property jQuery() As String
            Get
                Return ResourceManager.GetString("jQuery", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property layer_resize() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("layer_resize", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property magnifier_zoom_fit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("magnifier_zoom_fit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a 
        '''// MAP PROPERTIES
        '''
        '''var map = null;
        '''var map_canvas = null;
        '''                        
        '''var mouseLocation = null;
        '''var bounds = null;
        '''
        '''var backgroundColor = &quot;&lt;|BACK_COLOR|&gt;&quot;;
        '''var center = new google.maps.LatLng(11, -74);
        '''var disableDefaultUI = true;
        '''var disableDoubleClickZoom = false;
        '''var draggable = true;
        '''var draggableCursor = null;
        '''var draggingCursor = null;
        '''var keyboardShortcuts = true;
        '''var mapTypeControl = false;
        '''var mapTypeControlOptions = null;
        '''var mapTypeId = google.maps.MapTypeId.ROADM [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property map() As String
            Get
                Return ResourceManager.GetString("map", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a /*jslint browser: true, confusion: true, sloppy: true, vars: true, nomen: false, plusplus: false, indent: 2 */
        '''/*global window,google */
        '''
        '''/**
        ''' * @name MarkerClustererPlus for Google Maps V3
        ''' * @version 2.0.1 [July 27, 2011]
        ''' * @author Gary Little
        ''' * @fileoverview
        ''' * The library creates and manages per-zoom-level clusters for large amounts of markers.
        ''' * &lt;p&gt;
        ''' * This is an enhanced V3 implementation of the
        ''' * &lt;a href=&quot;http://gmaps-utility-library-dev.googlecode.com/svn/tags/markerclusterer/&quot;
        ''' * &gt;V [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property markerclusterer() As String
            Get
                Return ResourceManager.GetString("markerclusterer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a 
        '''var markers = [];
        '''
        '''function addMarker(item) {
        '''    
        '''    var t_marker = CatsToJsMarker(item);
        '''
        '''    markers.push(t_marker);
        '''
        '''};
        '''
        '''
        '''
        ''' 
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property markers() As String
            Get
                Return ResourceManager.GetString("markers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a &lt;!DOCTYPE html&gt; 
        '''
        '''&lt;html&gt; 
        '''    &lt;head&gt; 
        '''
        '''        &lt;title&gt;Pegazux Google Maps .Net Control 1.0&lt;/title&gt; 
        '''
        '''        &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1.0, user-scalable=no&quot; /&gt; 
        '''        &lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=UTF-8&quot;/&gt; 
        '''        
        '''        &lt;!--Estilos--&gt;
        '''        &lt;style type=&quot;text/css&quot; id=&quot;Map_Styles&quot;&gt; 
        '''	    
        '''	        html {
        '''		        width:100%; 
        '''		        height:100%;	  
        '''	        }
        '''
        '''	        body {
        '''		        width:100%; 
        '''		         [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property page() As String
            Get
                Return ResourceManager.GetString("page", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property printer() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("printer", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
