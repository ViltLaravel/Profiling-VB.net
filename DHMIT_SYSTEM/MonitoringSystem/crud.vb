﻿Imports MySql.Data.MySqlClient
Module crud  
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Public result As String
    Public add As String
    Public edit As String

#Region "old crud"
    Public Sub save_or_update(ByVal sql As String, ByVal add As String, ByVal edit As String)
        con.Open()
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dt = New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then

            con.Open()
            With cmd
                .Connection = con
                .CommandText = edit
                result = cmd.ExecuteNonQuery

            End With
            con.Close()
        Else
            con.Open()
            With cmd
                .Connection = con
                .CommandText = add
                result = cmd.ExecuteNonQuery

            End With
        End If
        con.Close()
    End Sub
    Public Sub view()
        cmd = New MySqlCommand("SELECT `EMPID`, `LEAVEAPPLIED`, `LEAVEDATE`, `LEAVEENDDATE`,`REASON`,`REMARKS`,`NODAYS` FROM `leave`", con)
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        'con.Open()
        con.Close()
        con.Dispose()
    End Sub

    Public Sub views()
        cmd = New MySqlCommand("SELECT `EMPID`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`,`REASON`,`REMARKS`FROM `leave`", con)
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        'con.Open()
        con.Close()
        con.Dispose()
    End Sub
    Public Sub viewdata()
        cmd = New MySqlCommand("SELECT * FROM employee", con)
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        'con.Open()
        con.Close()
        con.Dispose()
    End Sub

    Public Sub createNoMsg(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                cmd.ExecuteNonQuery()
               
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "createNoMsg")
        End Try

    End Sub
    Public Sub create(ByVal sql As String, ByVal msgsuccess As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    'MsgBox(msgsuccess & " is failed to save in the database ", MsgBoxStyle.Information)
                    MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
                Else
                    MsgBox(msgsuccess & " has been save to the database")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message & " create")
        End Try
        con.Close()
    End Sub
    Public Sub reloadDtg(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg")
        End Try

        con.Close()
        da.Dispose()
    End Sub
    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message & "reloadtxt")
        End Try

        con.Close()
        da.Dispose()
    End Sub
    Public Sub updates(ByVal sql As String, ByVal msgsuccess As String)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    ' MsgBox(msgsuccess & " is failed to updated in the database.", MsgBoxStyle.Information)
                    MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
                Else
                    MsgBox(msgsuccess & " has been updated in the database.")
                End If
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "updates")
        End Try

    End Sub
    Public Sub deletes(ByVal sql As String, ByVal msgsuccess As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            'If MessageBox.Show("Do you want to delete this rocord?", "Delete" _
            '                     , MessageBoxButtons.YesNo, MessageBoxIcon.Information) _
            '                     = Windows.Forms.DialogResult.Yes Then
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                ' MsgBox(msgsuccess & " is failed to delete in the database.")
                MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
            Else
                MsgBox(msgsuccess & " has been deleted in the database.")
            End If
            'End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Module


