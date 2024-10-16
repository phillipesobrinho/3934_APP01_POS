
Public Class frm_pos

    Dim Total As Double     'Declaraçao de variavel - Dim ... As

    Private Sub frm_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Arranque()
    End Sub

    Sub Desabilitar()
        'desabilitar as groupboxes
        gb_cafetaria.Enabled = False
        gb_pastelaria.Enabled = False
        gb_bebidas.Enabled = False
        pic_especial.Enabled = False

        'desabilitar os botoes
        btn_imprimir.Enabled = False
        btn_mais.Enabled = False
        btn_menos.Enabled = False
        btn_pagamento.Enabled = False
        btn_remover.Enabled = False
    End Sub

    Sub Arranque()

        Desabilitar()

        btn_novo.Text = "Novo"
        btn_novo.ForeColor = Color.Green

        lbl_pedido.ResetText()

        'limpar listas
        list_produto.Items.Clear()
        list_qtd.Items.Clear()
        list_preco.Items.Clear()
        list_total.Items.Clear()

        'limpar os totais e a pic_preview
        lbl_total.ResetText()
        lbl_numerario.ResetText()
        lbl_troco.ResetText()
        pic_preview.Image = Nothing

        'inicializar a variavel total
        Total = 0


    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        If (btn_novo.Text = "Novo") Then
            btn_novo.Text = "Cancelar"
            btn_novo.ForeColor = Color.Red

            lbl_pedido.Text = DateTime.Now.ToString("yyyyMMdd.hhmmss")

            'habilitar as groupboxes
            gb_cafetaria.Enabled = True
            gb_pastelaria.Enabled = True
            gb_bebidas.Enabled = True
            pic_especial.Enabled = True
        Else
            Arranque()
        End If
    End Sub

    Private Sub list_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_produto.SelectedIndexChanged
        list_qtd.SelectedIndex = list_produto.SelectedIndex
        list_preco.SelectedIndex = list_produto.SelectedIndex
        list_total.SelectedIndex = list_produto.SelectedIndex
    End Sub

    Private Sub list_qtd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_qtd.SelectedIndexChanged
        list_produto.SelectedIndex = list_qtd.SelectedIndex
        list_preco.SelectedIndex = list_qtd.SelectedIndex
        list_total.SelectedIndex = list_qtd.SelectedIndex
    End Sub

    Private Sub list_preco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_preco.SelectedIndexChanged
        list_produto.SelectedIndex = list_preco.SelectedIndex
        list_qtd.SelectedIndex = list_preco.SelectedIndex
        list_total.SelectedIndex = list_preco.SelectedIndex
    End Sub

    Private Sub list_total_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_total.SelectedIndexChanged
        list_produto.SelectedIndex = list_total.SelectedIndex
        list_qtd.SelectedIndex = list_total.SelectedIndex
        list_preco.SelectedIndex = list_total.SelectedIndex
    End Sub

    'metodo para evitar repetir codigo ao adicionar artigos
    Private Sub Adicionar_Produto(Imagem As PictureBox, Nome As String, Preco As Double)
        'localizar na lista dos produtos o nome do msm
        Dim Posicao, Qtd As Integer
        Dim Tpreco As Double

        Posicao = list_produto.FindString(Nome)

        If (Posicao <> -1) Then     'se o produto existe (diferente de -1)
            list_qtd.SetSelected(Posicao, True)
            Qtd = list_qtd.Items.Item(Posicao) + 1
            Tpreco = Qtd * Preco

            'escrever a qtd e preço nas listas
            list_qtd.Items.Item(Posicao) = Qtd
            list_total.Items.Item(Posicao) = FormatCurrency(Tpreco)
            Total += Preco
            lbl_total.Text = FormatCurrency(Total)
        Else
            list_produto.Items.Add(Nome)
            list_qtd.Items.Add(1)
            list_preco.Items.Add(FormatCurrency(Preco))
            list_total.Items.Add(FormatCurrency(Preco))
            Total += Preco
            lbl_total.Text = FormatCurrency(Total)
            pic_preview.Image = Imagem.Image

            btn_remover.Enabled = True
            btn_mais.Enabled = True
            btn_menos.Enabled = True
            btn_pagamento.Enabled = True
        End If
    End Sub

    Private Sub pic_meia_leite_Click(sender As Object, e As EventArgs) Handles pic_meia_leite.Click
        Adicionar_Produto(pic_meia_leite, "Meia de leite", 0.9)
    End Sub

    Private Sub pic_cafe_Click(sender As Object, e As EventArgs) Handles pic_cafe.Click
        Adicionar_Produto(pic_cafe, "Café", 0.8)
    End Sub

    Private Sub pic_descafeinado_Click(sender As Object, e As EventArgs) Handles pic_descafeinado.Click
        Adicionar_Produto(pic_descafeinado, "Descafeinado", 0.85)
    End Sub

    Private Sub pic_galao_Click(sender As Object, e As EventArgs) Handles pic_galao.Click
        Adicionar_Produto(pic_galao, "Galão", 0.95)
    End Sub

    Private Sub pic_garoto_Click(sender As Object, e As EventArgs) Handles pic_garoto.Click
        Adicionar_Produto(pic_garoto, "Garoto", 0.75)
    End Sub

    Private Sub pic_pingado_Click(sender As Object, e As EventArgs) Handles pic_pingado.Click
        Adicionar_Produto(pic_pingado, "Pingado", 0.85)
    End Sub

    Private Sub pic_doces_Click(sender As Object, e As EventArgs) Handles pic_doces.Click
        Adicionar_Produto(pic_doces, "Doces", 1.1)
    End Sub

    Private Sub pic_salgados_Click(sender As Object, e As EventArgs) Handles pic_salgados.Click
        Adicionar_Produto(pic_salgados, "Salgados", 1.15)
    End Sub

    Private Sub pic_sandes_Click(sender As Object, e As EventArgs) Handles pic_sandes.Click
        Adicionar_Produto(pic_sandes, "Sandes", 1.5)
    End Sub

    Private Sub pic_torrada_Click(sender As Object, e As EventArgs) Handles pic_torrada.Click
        Adicionar_Produto(pic_torrada, "Torrada", 1.0)
    End Sub

    Private Sub pic_tosta_Click(sender As Object, e As EventArgs) Handles pic_tosta.Click
        Adicionar_Produto(pic_tosta, "Tosta", 2.0)
    End Sub

    Private Sub pic_aguas_Click(sender As Object, e As EventArgs) Handles pic_aguas.Click
        Adicionar_Produto(pic_aguas, "Água", 1.0)
    End Sub

    Private Sub pic_gas_Click(sender As Object, e As EventArgs) Handles pic_gas.Click
        Adicionar_Produto(pic_gas, "Bebida com gás", 1.4)
    End Sub

    Private Sub pic_sem_gas_Click(sender As Object, e As EventArgs) Handles pic_sem_gas.Click
        Adicionar_Produto(pic_sem_gas, "Bebida sem gás", 1.2)
    End Sub

    Private Sub pic_naturais_Click(sender As Object, e As EventArgs) Handles pic_naturais.Click
        Adicionar_Produto(pic_naturais, "Sumo natural", 1.5)
    End Sub

    Private Sub btn_mais_Click(sender As Object, e As EventArgs) Handles btn_mais.Click
        Dim Posicao, Qtd As Integer
        Dim Tpreco As Double

        Posicao = list_qtd.SelectedIndex

        If (Posicao <> -1) Then     'se o produto existe (diferente de -1)
            Tpreco = list_preco.Items.Item(Posicao)
            Qtd = list_qtd.Items.Item(Posicao) + 1
            list_qtd.Items.Item(Posicao) = Qtd
            list_total.Items.Item(Posicao) = FormatCurrency(Qtd * Tpreco)
            Total += Tpreco
            lbl_total.Text = FormatCurrency(Total)
        Else
            MsgBox("Não existem items selecionados", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        Dim Posicao, Qtd As Integer
        Dim Tpreco As Double

        Posicao = list_qtd.SelectedIndex

        If (Posicao <> -1) Then     'se o produto existe (diferente de -1)
            Tpreco = list_preco.Items.Item(Posicao)
            Qtd = list_qtd.Items.Item(Posicao) - 1
            list_qtd.Items.Item(Posicao) = Qtd
            list_total.Items.Item(Posicao) = FormatCurrency(Qtd * Tpreco)
            Total -= Tpreco
            lbl_total.Text = FormatCurrency(Total)

            If Qtd = 0 Then
                list_produto.Items.RemoveAt(Posicao)
                list_qtd.Items.RemoveAt(Posicao)
                list_preco.Items.RemoveAt(Posicao)
                list_total.Items.RemoveAt(Posicao)
            End If

            If (list_produto.Items.Count = 0) Then
                btn_remover.Enabled = False
                btn_mais.Enabled = False
                btn_menos.Enabled = False
                btn_pagamento.Enabled = False
                lbl_total.ResetText()
            Else
                list_produto.SelectedIndex = 0
            End If

        Else
            MsgBox("Não existem items selecionados", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

    Private Sub btn_remover_Click(sender As Object, e As EventArgs) Handles btn_remover.Click
        If (list_produto.SelectedIndex < 0) Then
            MsgBox("Não existem items selecionados", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub
        End If

        Dim Posicao As Integer
        Dim Preco As Double
        Dim Resposta As String

        Posicao = list_produto.SelectedIndex
        Preco = list_total.Items.Item(Posicao)
        Resposta = MsgBox("Confirma eliminar o artigo?", MsgBoxStyle.YesNo +
                          MsgBoxStyle.Question, "Eliminar artigo")

        If (Resposta = vbYes) Then
            list_produto.Items.RemoveAt(Posicao)
            list_qtd.Items.RemoveAt(Posicao)
            list_preco.Items.RemoveAt(Posicao)
            list_total.Items.RemoveAt(Posicao)
            Total -= Preco
            lbl_total.Text = FormatCurrency(Total)
        End If

        If (list_produto.Items.Count = 0) Then
            btn_remover.Enabled = False
            btn_mais.Enabled = False
            btn_menos.Enabled = False
            btn_pagamento.Enabled = False
            lbl_total.ResetText()
        Else
            list_produto.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_pagamento_Click(sender As Object, e As EventArgs) Handles btn_pagamento.Click
        Dim Valor As Double = InputBox("Digite o valor em numerário")

        If (Valor < Total) Then
            MsgBox("Valor insuficiente", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub
        End If

        lbl_numerario.Text = FormatCurrency(Valor)
        lbl_troco.Text = FormatCurrency(Valor - Total)

        Desabilitar()
        btn_imprimir.Enabled = True
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Titulo As New Font("Verdana", 16, FontStyle.Bold)
        Dim Titulo1 As New Font("Verdana", 8, FontStyle.Bold)
        Dim Titulo2 As New Font("Verdana", 10, FontStyle.Bold)
        Dim Linha As Integer

        e.Graphics.DrawString("BAR XYZ, Lda.", Titulo, Brushes.Blue, 50, 50)
        e.Graphics.DrawString("Rua Alves Redol nº123A", Titulo1, Brushes.Blue, 50, 80)
        e.Graphics.DrawString("1150-020 Lisboa", Titulo1, Brushes.Blue, 50, 100)
        e.Graphics.DrawString("NIF: 502285401", Titulo1, Brushes.Blue, 50, 120)

        e.Graphics.DrawString("Descrição", Titulo2, Brushes.Red, 50, 150)
        e.Graphics.DrawString("Qtd.", Titulo2, Brushes.Red, 250, 150)
        e.Graphics.DrawString("Preço", Titulo2, Brushes.Red, 350, 150)
        e.Graphics.DrawString("Total", Titulo2, Brushes.Red, 450, 150)

        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, 170, 500, 170)

        Linha = 180
        For i = 0 To list_produto.Items.Count - 1
            e.Graphics.DrawString(list_produto.Items(i), Titulo2, Brushes.Black, 50, Linha)
            e.Graphics.DrawString(list_qtd.Items(i), Titulo2, Brushes.Black, 250, Linha)
            e.Graphics.DrawString(list_preco.Items(i), Titulo2, Brushes.Black, 350, Linha)
            e.Graphics.DrawString(list_total.Items(i), Titulo2, Brushes.Black, 450, Linha)
            Linha += 20
        Next
        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, Linha, 500, Linha)
        e.Graphics.DrawString("Total: " & lbl_total.Text, Titulo2, Brushes.Red, 50, Linha + 20)
        e.Graphics.DrawString("Numerário: " & lbl_numerario.Text, Titulo2, Brushes.Red, 50, Linha + 40)
        e.Graphics.DrawString("Troco: " & lbl_troco.Text, Titulo2, Brushes.Red, 50, Linha + 60)
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        PrintPreviewDialog1.ShowDialog()

        'registar os dados na base de dados

        'limpar o layout

        Arranque()
    End Sub
End Class
