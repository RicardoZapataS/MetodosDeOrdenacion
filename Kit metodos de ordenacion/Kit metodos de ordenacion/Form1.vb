Imports System.Threading

Public Class Form1

	Dim Vector() As Int64
	Dim tamaño As Int64
	Dim pass As Boolean = False

	Private Sub MostrarSalida()
		lbSalida.Items.Clear() 'limpia la lista de numeros
		For i As Integer = 0 To tamaño - 1
			lbSalida.Items.Add(Vector(i))
		Next
	End Sub

	Private Sub CargarVector()
		tamaño = lbEntrada.Items.Count
		ReDim Vector(tamaño - 1)
		For i = 0 To lbEntrada.Items.Count - 1
			Vector(i) = lbEntrada.Items(i)
		Next i
	End Sub

	Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
		lbEntrada.Items.Add(nudValor.Value)
	End Sub

	Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
		lbEntrada.Items.Clear()
	End Sub

	Private Sub btnBurbuja_Click(sender As Object, e As EventArgs) Handles btnBurbuja.Click
		CargarVector()
		Dim puntero As Integer = 0 'indica en que posiciòn se encuentra el puntero
		Dim Auxiliar As Integer = 0 ' sedeclara una variable que se utilizara para el almacenamiento temporal
		For I As Integer = 1 To tamaño - 1
			puntero = 0
			For j As Integer = 1 To tamaño - I
				If Vector(puntero) > Vector(puntero + 1) Then
					Auxiliar = Vector(puntero + 1)
					Vector(puntero + 1) = Vector(puntero)
					Vector(puntero) = Auxiliar
				End If
				puntero = puntero + 1
			Next
		Next
		MostrarSalida()
	End Sub

	Private Sub btnBidireccional_Click(sender As Object, e As EventArgs) Handles btnBidireccional.Click
		CargarVector()
		Dim der As Integer = 0
		Dim izq As Integer = 0
		Dim aux As Integer = 0

		der = tamaño - 1
		Do
			For i As Integer = izq To der - 1
				If Vector(i) > Vector(i + 1) Then
					aux = Vector(i)
					Vector(i) = Vector(i + 1)
					Vector(i + 1) = aux
				End If
			Next
			For j As Integer = der - 1 To izq Step -1
				If Vector(j) > Vector(j + 1) Then
					aux = Vector(j)
					Vector(j) = Vector(j + 1)
					Vector(j + 1) = aux
				End If
			Next
			izq += 1
			der -= 1
		Loop While izq < der
		MostrarSalida()
	End Sub

	Private Sub btnMezcla_Click(sender As Object, e As EventArgs) Handles btnMezcla.Click
		CargarVector()
		Vector = MergeSort(Vector)
		MostrarSalida()
	End Sub
	Function MergeSort(Arr() As Int64) As Int64()

		Dim ArrLeftHalf() As Int64
		Dim ArrRightHalf() As Int64

		If UBound(Arr) = 0 Then
			Return Arr
			Exit Function
		Else
			Call SplitList(Arr, ArrLeftHalf, ArrRightHalf)
			ArrLeftHalf = MergeSort(ArrLeftHalf)
			ArrRightHalf = MergeSort(ArrRightHalf)
			Return MergeTwoLists(ArrLeftHalf, ArrRightHalf)
		End If

	End Function

	Sub SplitList(Arr() As Int64, ByRef ArrLeft() As Int64, ByRef ArrRight() As Int64)
		'Splits a list into two and returns the two resulting lists via parameters

		Dim iMiddle As Integer = Math.Floor((LBound(Arr) + UBound(Arr)) / 2)

		'Populate empty list with left half of original list
		ReDim ArrLeft(iMiddle)
		For i As Integer = 0 To iMiddle
			ArrLeft(i) = Arr(i)
		Next

		'Populate empty list with right half of original list
		Dim iFill As Integer
		Dim v As Integer = UBound(Arr)
		Dim v2 As Integer = UBound(ArrLeft)
		Dim vf As Integer = v - v2 - 1
		ReDim ArrRight(vf)
		For i As Integer = iMiddle + 1 To UBound(Arr)
			ArrRight(iFill) = Arr(i)
			iFill = iFill + 1
		Next

	End Sub

	Function MergeTwoLists(Arr1() As Int64, Arr2() As Int64) As Int64()

		'Merge two sorted lists into one sorted list
		Dim Arr3() As Int64   'Source lists will be merged into new list Arr3

		ReDim Arr3(UBound(Arr1) + UBound(Arr2) + 1)

		Dim Ptr1 As Integer
		Dim Ptr2 As Integer
		Dim Ptr3 As Integer

		'Repeat until one of the arrays is exhausted
		Do While (Ptr3 <= UBound(Arr3)) And (Ptr1 <= UBound(Arr1)) And (Ptr2 <= UBound(Arr2))
			If Arr1(Ptr1) < Arr2(Ptr2) Then
				Arr3(Ptr3) = Arr1(Ptr1)
				Ptr1 = Ptr1 + 1
			Else
				Arr3(Ptr3) = Arr2(Ptr2)
				Ptr2 = Ptr2 + 1
			End If
			Ptr3 = Ptr3 + 1
		Loop
		'Copy reamining items from larger of the source arrays into Arr3
		If Ptr1 <= UBound(Arr1) Then         'still some items in Arr1
			Do Until Ptr3 = UBound(Arr3) + 1
				Arr3(Ptr3) = Arr1(Ptr1)
				Ptr1 = Ptr1 + 1
				Ptr3 = Ptr3 + 1
			Loop
		ElseIf Ptr2 <= UBound(Arr2) Then     'still some items in Arr2
			Do Until Ptr3 = UBound(Arr3) + 1
				Arr3(Ptr3) = Arr2(Ptr2)
				Ptr2 = Ptr2 + 1
				Ptr3 = Ptr3 + 1
			Loop
		End If

		Return Arr3
	End Function

	Private Sub btnInsercioon_Click(sender As Object, e As EventArgs) Handles btnInsercioon.Click
		CargarVector()
		Dim temp As Double
		Dim inner As Integer, outer As Integer
		For outer = 0 To tamaño - 1
			temp = Vector(outer)
			inner = outer
			While inner > 0 AndAlso Vector(inner - 1) >= temp
				Vector(inner) = Vector(inner - 1)
				inner -= 1
			End While
			Vector(inner) = temp
		Next
		MostrarSalida()
	End Sub

	Private Sub btnSeleccion_Click(sender As Object, e As EventArgs) Handles btnSeleccion.Click
		CargarVector()
		Dim min As Integer

		For i As Integer = 0 To tamaño - 2
			min = i

			For j As Integer = i + 1 To tamaño - 1
				If Vector(j) < Vector(min) Then
					min = j
				End If
			Next

			Dim temp As Integer = Vector(min)
			Vector(min) = Vector(i)
			Vector(i) = temp
		Next
		MostrarSalida()
	End Sub

	Private Sub btnQuick_Click(sender As Object, e As EventArgs) Handles btnQuick.Click
		CargarVector()
		QuickSortVariants(Vector, 0, tamaño - 1)
		MostrarSalida()
	End Sub
	Public Sub QuickSortVariants(vArray() As Int64, inLow As Int64, inHi As Int64)
		Dim pivot As Int64
		Dim tmpSwap As Int64
		Dim tmpLow As Int64
		Dim tmpHi As Int64
		tmpLow = inLow
		tmpHi = inHi
		pivot = vArray((inLow + inHi) \ 2)
		While (tmpLow <= tmpHi)
			While (vArray(tmpLow) < pivot And tmpLow < inHi)
				tmpLow = tmpLow + 1
			End While
			While (pivot < vArray(tmpHi) And tmpHi > inLow)
				tmpHi = tmpHi - 1
			End While
			If (tmpLow <= tmpHi) Then
				tmpSwap = vArray(tmpLow)
				vArray(tmpLow) = vArray(tmpHi)
				vArray(tmpHi) = tmpSwap
				tmpLow = tmpLow + 1
				tmpHi = tmpHi - 1
			End If
		End While
		If (inLow < tmpHi) Then QuickSortVariants(vArray, inLow, tmpHi)
		If (tmpLow < inHi) Then QuickSortVariants(vArray, tmpLow, inHi)

	End Sub
End Class
