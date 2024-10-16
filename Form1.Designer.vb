<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pos))
        gb_cafetaria = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pic_pingado = New PictureBox()
        pic_garoto = New PictureBox()
        pic_galao = New PictureBox()
        pic_descafeinado = New PictureBox()
        pic_cafe = New PictureBox()
        pic_meia_leite = New PictureBox()
        gb_pastelaria = New GroupBox()
        pic_doces = New PictureBox()
        Label8 = New Label()
        pic_salgados = New PictureBox()
        Label9 = New Label()
        pic_sandes = New PictureBox()
        Label10 = New Label()
        pic_torrada = New PictureBox()
        Label11 = New Label()
        pic_tosta = New PictureBox()
        Label12 = New Label()
        gb_bebidas = New GroupBox()
        pic_aguas = New PictureBox()
        pic_gas = New PictureBox()
        Label15 = New Label()
        pic_sem_gas = New PictureBox()
        Label16 = New Label()
        pic_naturais = New PictureBox()
        Label17 = New Label()
        Label18 = New Label()
        pic_especial = New PictureBox()
        pic_preview = New PictureBox()
        lbl_pedido = New Label()
        list_produto = New ListBox()
        list_qtd = New ListBox()
        list_preco = New ListBox()
        list_total = New ListBox()
        btn_remover = New Button()
        btn_pagamento = New Button()
        btn_novo = New Button()
        btn_imprimir = New Button()
        btn_menos = New Button()
        btn_mais = New Button()
        Label7 = New Label()
        lbl_total = New Label()
        lbl_numerario = New Label()
        Label14 = New Label()
        lbl_troco = New Label()
        Label20 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        gb_cafetaria.SuspendLayout()
        CType(pic_pingado, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_garoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_galao, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_descafeinado, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_cafe, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_meia_leite, ComponentModel.ISupportInitialize).BeginInit()
        gb_pastelaria.SuspendLayout()
        CType(pic_doces, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_salgados, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sandes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_torrada, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_tosta, ComponentModel.ISupportInitialize).BeginInit()
        gb_bebidas.SuspendLayout()
        CType(pic_aguas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_gas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sem_gas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_naturais, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_especial, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_preview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gb_cafetaria
        ' 
        gb_cafetaria.Controls.Add(Label4)
        gb_cafetaria.Controls.Add(Label5)
        gb_cafetaria.Controls.Add(Label6)
        gb_cafetaria.Controls.Add(Label3)
        gb_cafetaria.Controls.Add(Label2)
        gb_cafetaria.Controls.Add(Label1)
        gb_cafetaria.Controls.Add(pic_pingado)
        gb_cafetaria.Controls.Add(pic_garoto)
        gb_cafetaria.Controls.Add(pic_galao)
        gb_cafetaria.Controls.Add(pic_descafeinado)
        gb_cafetaria.Controls.Add(pic_cafe)
        gb_cafetaria.Controls.Add(pic_meia_leite)
        gb_cafetaria.Location = New Point(13, 9)
        gb_cafetaria.Name = "gb_cafetaria"
        gb_cafetaria.Size = New Size(204, 200)
        gb_cafetaria.TabIndex = 0
        gb_cafetaria.TabStop = False
        gb_cafetaria.Text = "Cafetaria"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(136, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 19)
        Label4.TabIndex = 11
        Label4.Text = "0.85 €"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(73, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 19)
        Label5.TabIndex = 10
        Label5.Text = "0.75 €"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(10, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 19)
        Label6.TabIndex = 9
        Label6.Text = "0.95 €"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(136, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 8
        Label3.Text = "0.85 €"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(73, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 19)
        Label2.TabIndex = 7
        Label2.Text = "0.80 €"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 19)
        Label1.TabIndex = 6
        Label1.Text = "0.90 €"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_pingado
        ' 
        pic_pingado.Image = My.Resources.Resources.CafePingado
        pic_pingado.Location = New Point(136, 114)
        pic_pingado.Name = "pic_pingado"
        pic_pingado.Size = New Size(57, 50)
        pic_pingado.SizeMode = PictureBoxSizeMode.StretchImage
        pic_pingado.TabIndex = 5
        pic_pingado.TabStop = False
        ' 
        ' pic_garoto
        ' 
        pic_garoto.Image = My.Resources.Resources.garoto
        pic_garoto.Location = New Point(73, 114)
        pic_garoto.Name = "pic_garoto"
        pic_garoto.Size = New Size(57, 50)
        pic_garoto.SizeMode = PictureBoxSizeMode.StretchImage
        pic_garoto.TabIndex = 4
        pic_garoto.TabStop = False
        ' 
        ' pic_galao
        ' 
        pic_galao.Image = My.Resources.Resources.Galao
        pic_galao.Location = New Point(10, 114)
        pic_galao.Name = "pic_galao"
        pic_galao.Size = New Size(57, 50)
        pic_galao.SizeMode = PictureBoxSizeMode.StretchImage
        pic_galao.TabIndex = 3
        pic_galao.TabStop = False
        ' 
        ' pic_descafeinado
        ' 
        pic_descafeinado.Image = My.Resources.Resources.DesCafeinado
        pic_descafeinado.Location = New Point(136, 26)
        pic_descafeinado.Name = "pic_descafeinado"
        pic_descafeinado.Size = New Size(57, 50)
        pic_descafeinado.SizeMode = PictureBoxSizeMode.StretchImage
        pic_descafeinado.TabIndex = 2
        pic_descafeinado.TabStop = False
        ' 
        ' pic_cafe
        ' 
        pic_cafe.Image = My.Resources.Resources.Café
        pic_cafe.Location = New Point(73, 26)
        pic_cafe.Name = "pic_cafe"
        pic_cafe.Size = New Size(57, 50)
        pic_cafe.SizeMode = PictureBoxSizeMode.StretchImage
        pic_cafe.TabIndex = 1
        pic_cafe.TabStop = False
        ' 
        ' pic_meia_leite
        ' 
        pic_meia_leite.Image = My.Resources.Resources.MeiaDeLeite
        pic_meia_leite.Location = New Point(10, 26)
        pic_meia_leite.Name = "pic_meia_leite"
        pic_meia_leite.Size = New Size(57, 50)
        pic_meia_leite.SizeMode = PictureBoxSizeMode.StretchImage
        pic_meia_leite.TabIndex = 0
        pic_meia_leite.TabStop = False
        ' 
        ' gb_pastelaria
        ' 
        gb_pastelaria.Controls.Add(pic_doces)
        gb_pastelaria.Controls.Add(Label8)
        gb_pastelaria.Controls.Add(pic_salgados)
        gb_pastelaria.Controls.Add(Label9)
        gb_pastelaria.Controls.Add(pic_sandes)
        gb_pastelaria.Controls.Add(Label10)
        gb_pastelaria.Controls.Add(pic_torrada)
        gb_pastelaria.Controls.Add(Label11)
        gb_pastelaria.Controls.Add(pic_tosta)
        gb_pastelaria.Controls.Add(Label12)
        gb_pastelaria.Location = New Point(13, 218)
        gb_pastelaria.Name = "gb_pastelaria"
        gb_pastelaria.Size = New Size(204, 200)
        gb_pastelaria.TabIndex = 1
        gb_pastelaria.TabStop = False
        gb_pastelaria.Text = "Pastelaria"
        ' 
        ' pic_doces
        ' 
        pic_doces.Image = My.Resources.Resources.Bolos
        pic_doces.Location = New Point(10, 22)
        pic_doces.Name = "pic_doces"
        pic_doces.Size = New Size(57, 50)
        pic_doces.SizeMode = PictureBoxSizeMode.StretchImage
        pic_doces.TabIndex = 12
        pic_doces.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(73, 163)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 19)
        Label8.TabIndex = 22
        Label8.Text = "2.00 €"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_salgados
        ' 
        pic_salgados.Image = My.Resources.Resources.salgados
        pic_salgados.Location = New Point(73, 22)
        pic_salgados.Name = "pic_salgados"
        pic_salgados.Size = New Size(57, 50)
        pic_salgados.SizeMode = PictureBoxSizeMode.StretchImage
        pic_salgados.TabIndex = 13
        pic_salgados.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 163)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 19)
        Label9.TabIndex = 21
        Label9.Text = "1.00 €"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_sandes
        ' 
        pic_sandes.Image = My.Resources.Resources.Sandes
        pic_sandes.Location = New Point(136, 22)
        pic_sandes.Name = "pic_sandes"
        pic_sandes.Size = New Size(57, 50)
        pic_sandes.SizeMode = PictureBoxSizeMode.StretchImage
        pic_sandes.TabIndex = 14
        pic_sandes.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(136, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 19)
        Label10.TabIndex = 20
        Label10.Text = "1.50 €"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_torrada
        ' 
        pic_torrada.Image = My.Resources.Resources.Torrada
        pic_torrada.Location = New Point(10, 110)
        pic_torrada.Name = "pic_torrada"
        pic_torrada.Size = New Size(57, 50)
        pic_torrada.SizeMode = PictureBoxSizeMode.StretchImage
        pic_torrada.TabIndex = 15
        pic_torrada.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(73, 75)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 19)
        Label11.TabIndex = 19
        Label11.Text = "1.15 €"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_tosta
        ' 
        pic_tosta.Image = My.Resources.Resources.Tostas
        pic_tosta.Location = New Point(73, 110)
        pic_tosta.Name = "pic_tosta"
        pic_tosta.Size = New Size(57, 50)
        pic_tosta.SizeMode = PictureBoxSizeMode.StretchImage
        pic_tosta.TabIndex = 16
        pic_tosta.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(10, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 19)
        Label12.TabIndex = 18
        Label12.Text = "1.10 €"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gb_bebidas
        ' 
        gb_bebidas.Controls.Add(pic_aguas)
        gb_bebidas.Controls.Add(pic_gas)
        gb_bebidas.Controls.Add(Label15)
        gb_bebidas.Controls.Add(pic_sem_gas)
        gb_bebidas.Controls.Add(Label16)
        gb_bebidas.Controls.Add(pic_naturais)
        gb_bebidas.Controls.Add(Label17)
        gb_bebidas.Controls.Add(Label18)
        gb_bebidas.Location = New Point(223, 9)
        gb_bebidas.Name = "gb_bebidas"
        gb_bebidas.Size = New Size(204, 200)
        gb_bebidas.TabIndex = 1
        gb_bebidas.TabStop = False
        gb_bebidas.Text = "Bebidas"
        ' 
        ' pic_aguas
        ' 
        pic_aguas.Image = My.Resources.Resources.Aguas
        pic_aguas.Location = New Point(8, 26)
        pic_aguas.Name = "pic_aguas"
        pic_aguas.Size = New Size(57, 50)
        pic_aguas.SizeMode = PictureBoxSizeMode.StretchImage
        pic_aguas.TabIndex = 24
        pic_aguas.TabStop = False
        ' 
        ' pic_gas
        ' 
        pic_gas.Image = My.Resources.Resources.ComGas
        pic_gas.Location = New Point(71, 26)
        pic_gas.Name = "pic_gas"
        pic_gas.Size = New Size(57, 50)
        pic_gas.SizeMode = PictureBoxSizeMode.StretchImage
        pic_gas.TabIndex = 25
        pic_gas.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(8, 167)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 19)
        Label15.TabIndex = 33
        Label15.Text = "1.50 €"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_sem_gas
        ' 
        pic_sem_gas.Image = My.Resources.Resources.SemGas
        pic_sem_gas.Location = New Point(134, 26)
        pic_sem_gas.Name = "pic_sem_gas"
        pic_sem_gas.Size = New Size(57, 50)
        pic_sem_gas.SizeMode = PictureBoxSizeMode.StretchImage
        pic_sem_gas.TabIndex = 26
        pic_sem_gas.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(134, 79)
        Label16.Name = "Label16"
        Label16.Size = New Size(57, 19)
        Label16.TabIndex = 32
        Label16.Text = "1.20 €"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_naturais
        ' 
        pic_naturais.Image = My.Resources.Resources.Naturais
        pic_naturais.Location = New Point(8, 114)
        pic_naturais.Name = "pic_naturais"
        pic_naturais.Size = New Size(57, 50)
        pic_naturais.SizeMode = PictureBoxSizeMode.StretchImage
        pic_naturais.TabIndex = 27
        pic_naturais.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(71, 79)
        Label17.Name = "Label17"
        Label17.Size = New Size(57, 19)
        Label17.TabIndex = 31
        Label17.Text = "1.40 €"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label18.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(8, 79)
        Label18.Name = "Label18"
        Label18.Size = New Size(57, 19)
        Label18.TabIndex = 30
        Label18.Text = "1.00 €"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pic_especial
        ' 
        pic_especial.Image = My.Resources.Resources.no_image
        pic_especial.Location = New Point(223, 228)
        pic_especial.Name = "pic_especial"
        pic_especial.Size = New Size(65, 56)
        pic_especial.SizeMode = PictureBoxSizeMode.StretchImage
        pic_especial.TabIndex = 6
        pic_especial.TabStop = False
        ' 
        ' pic_preview
        ' 
        pic_preview.Location = New Point(223, 293)
        pic_preview.Name = "pic_preview"
        pic_preview.Size = New Size(204, 125)
        pic_preview.SizeMode = PictureBoxSizeMode.StretchImage
        pic_preview.TabIndex = 7
        pic_preview.TabStop = False
        ' 
        ' lbl_pedido
        ' 
        lbl_pedido.BorderStyle = BorderStyle.FixedSingle
        lbl_pedido.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_pedido.Location = New Point(444, 18)
        lbl_pedido.Name = "lbl_pedido"
        lbl_pedido.Size = New Size(354, 23)
        lbl_pedido.TabIndex = 8
        lbl_pedido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' list_produto
        ' 
        list_produto.FormattingEnabled = True
        list_produto.ItemHeight = 15
        list_produto.Location = New Point(444, 55)
        list_produto.Name = "list_produto"
        list_produto.Size = New Size(157, 274)
        list_produto.TabIndex = 9
        ' 
        ' list_qtd
        ' 
        list_qtd.FormattingEnabled = True
        list_qtd.ItemHeight = 15
        list_qtd.Location = New Point(597, 55)
        list_qtd.Name = "list_qtd"
        list_qtd.Size = New Size(47, 274)
        list_qtd.TabIndex = 10
        ' 
        ' list_preco
        ' 
        list_preco.FormattingEnabled = True
        list_preco.ItemHeight = 15
        list_preco.Location = New Point(642, 55)
        list_preco.Name = "list_preco"
        list_preco.Size = New Size(68, 274)
        list_preco.TabIndex = 11
        ' 
        ' list_total
        ' 
        list_total.FormattingEnabled = True
        list_total.ItemHeight = 15
        list_total.Location = New Point(707, 55)
        list_total.Name = "list_total"
        list_total.Size = New Size(91, 274)
        list_total.TabIndex = 12
        ' 
        ' btn_remover
        ' 
        btn_remover.Location = New Point(444, 336)
        btn_remover.Name = "btn_remover"
        btn_remover.Size = New Size(68, 38)
        btn_remover.TabIndex = 13
        btn_remover.Text = "Remover Artigo"
        btn_remover.UseVisualStyleBackColor = True
        ' 
        ' btn_pagamento
        ' 
        btn_pagamento.Location = New Point(515, 336)
        btn_pagamento.Name = "btn_pagamento"
        btn_pagamento.Size = New Size(76, 38)
        btn_pagamento.TabIndex = 14
        btn_pagamento.Text = "Pagamento"
        btn_pagamento.UseVisualStyleBackColor = True
        ' 
        ' btn_novo
        ' 
        btn_novo.Location = New Point(444, 380)
        btn_novo.Name = "btn_novo"
        btn_novo.Size = New Size(68, 38)
        btn_novo.TabIndex = 15
        btn_novo.Text = "Novo"
        btn_novo.UseVisualStyleBackColor = True
        ' 
        ' btn_imprimir
        ' 
        btn_imprimir.Location = New Point(515, 380)
        btn_imprimir.Name = "btn_imprimir"
        btn_imprimir.Size = New Size(76, 38)
        btn_imprimir.TabIndex = 16
        btn_imprimir.Text = "Imprimir Talão"
        btn_imprimir.UseVisualStyleBackColor = True
        ' 
        ' btn_menos
        ' 
        btn_menos.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btn_menos.ForeColor = SystemColors.ActiveCaptionText
        btn_menos.ImageAlign = ContentAlignment.MiddleRight
        btn_menos.Location = New Point(597, 380)
        btn_menos.Name = "btn_menos"
        btn_menos.Size = New Size(39, 38)
        btn_menos.TabIndex = 18
        btn_menos.Text = "-"
        btn_menos.UseVisualStyleBackColor = True
        ' 
        ' btn_mais
        ' 
        btn_mais.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btn_mais.Location = New Point(597, 336)
        btn_mais.Name = "btn_mais"
        btn_mais.Size = New Size(39, 38)
        btn_mais.TabIndex = 17
        btn_mais.Text = "+"
        btn_mais.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(684, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 17)
        Label7.TabIndex = 19
        Label7.Text = "Total"
        ' 
        ' lbl_total
        ' 
        lbl_total.BackColor = SystemColors.GradientInactiveCaption
        lbl_total.BorderStyle = BorderStyle.FixedSingle
        lbl_total.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_total.Location = New Point(729, 335)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(69, 23)
        lbl_total.TabIndex = 20
        lbl_total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_numerario
        ' 
        lbl_numerario.BackColor = SystemColors.GradientInactiveCaption
        lbl_numerario.BorderStyle = BorderStyle.FixedSingle
        lbl_numerario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_numerario.Location = New Point(729, 365)
        lbl_numerario.Name = "lbl_numerario"
        lbl_numerario.Size = New Size(69, 23)
        lbl_numerario.TabIndex = 22
        lbl_numerario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(650, 368)
        Label14.Name = "Label14"
        Label14.Size = New Size(74, 17)
        Label14.TabIndex = 21
        Label14.Text = "Numerário"
        ' 
        ' lbl_troco
        ' 
        lbl_troco.BackColor = SystemColors.GradientInactiveCaption
        lbl_troco.BorderStyle = BorderStyle.FixedSingle
        lbl_troco.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_troco.Location = New Point(729, 395)
        lbl_troco.Name = "lbl_troco"
        lbl_troco.Size = New Size(69, 23)
        lbl_troco.TabIndex = 24
        lbl_troco.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(681, 398)
        Label20.Name = "Label20"
        Label20.Size = New Size(42, 17)
        Label20.TabIndex = 23
        Label20.Text = "Troco"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' frm_pos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 430)
        Controls.Add(lbl_troco)
        Controls.Add(Label20)
        Controls.Add(lbl_numerario)
        Controls.Add(Label14)
        Controls.Add(lbl_total)
        Controls.Add(Label7)
        Controls.Add(btn_menos)
        Controls.Add(btn_mais)
        Controls.Add(btn_imprimir)
        Controls.Add(btn_novo)
        Controls.Add(btn_pagamento)
        Controls.Add(btn_remover)
        Controls.Add(gb_bebidas)
        Controls.Add(list_total)
        Controls.Add(list_preco)
        Controls.Add(list_qtd)
        Controls.Add(list_produto)
        Controls.Add(lbl_pedido)
        Controls.Add(pic_preview)
        Controls.Add(pic_especial)
        Controls.Add(gb_pastelaria)
        Controls.Add(gb_cafetaria)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frm_pos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS"
        gb_cafetaria.ResumeLayout(False)
        CType(pic_pingado, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_garoto, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_galao, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_descafeinado, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_cafe, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_meia_leite, ComponentModel.ISupportInitialize).EndInit()
        gb_pastelaria.ResumeLayout(False)
        CType(pic_doces, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_salgados, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sandes, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_torrada, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_tosta, ComponentModel.ISupportInitialize).EndInit()
        gb_bebidas.ResumeLayout(False)
        CType(pic_aguas, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_gas, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sem_gas, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_naturais, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_especial, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_preview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gb_cafetaria As GroupBox
    Friend WithEvents pic_meia_leite As PictureBox
    Friend WithEvents gb_pastelaria As GroupBox
    Friend WithEvents gb_bebidas As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_pingado As PictureBox
    Friend WithEvents pic_garoto As PictureBox
    Friend WithEvents pic_galao As PictureBox
    Friend WithEvents pic_descafeinado As PictureBox
    Friend WithEvents pic_cafe As PictureBox
    Friend WithEvents pic_especial As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pic_doces As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pic_salgados As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pic_sandes As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pic_torrada As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents pic_tosta As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents pic_aguas As PictureBox
    Friend WithEvents pic_gas As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents pic_sem_gas As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents pic_naturais As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pic_preview As PictureBox
    Friend WithEvents lbl_pedido As Label
    Friend WithEvents list_produto As ListBox
    Friend WithEvents list_qtd As ListBox
    Friend WithEvents list_preco As ListBox
    Friend WithEvents list_total As ListBox
    Friend WithEvents btn_remover As Button
    Friend WithEvents btn_pagamento As Button
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents btn_menos As Button
    Friend WithEvents btn_mais As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_numerario As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_troco As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
