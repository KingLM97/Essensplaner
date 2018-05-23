<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RestaurantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.FKRestaurantKategorieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBestellen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clmWunsch = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FKKategorieSpeiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clmRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmLöschen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BestellungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblPreis = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Essensplaner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.FKRestaurantKategorieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKKategorieSpeiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestellungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(888, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.RestaurantBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(171, 555)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ID"
        '
        'RestaurantBindingSource
        '
        Me.RestaurantBindingSource.DataMember = "Restaurant"
        Me.RestaurantBindingSource.DataSource = Me.Essensplaner
        '
        'Essensplaner
        '
        Me.Essensplaner.DataSetName = "Essensplaner"
        Me.Essensplaner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(177, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(711, 561)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ListBox2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(711, 375)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.FKRestaurantKategorieBindingSource
        Me.ListBox2.DisplayMember = "Name"
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(136, 369)
        Me.ListBox2.TabIndex = 0
        Me.ListBox2.ValueMember = "ID"
        '
        'FKRestaurantKategorieBindingSource
        '
        Me.FKRestaurantKategorieBindingSource.DataMember = "FK_Restaurant_Kategorie"
        Me.FKRestaurantKategorieBindingSource.DataSource = Me.RestaurantBindingSource
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(145, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(563, 369)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.BeschreibungDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.clmBestellen, Me.clmWunsch})
        Me.DataGridView1.DataSource = Me.FKKategorieSpeiseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(557, 281)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BeschreibungDataGridViewTextBoxColumn
        '
        Me.BeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.Name = "BeschreibungDataGridViewTextBoxColumn"
        Me.BeschreibungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Preis"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Preis"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'clmBestellen
        '
        Me.clmBestellen.HeaderText = "Bestellen"
        Me.clmBestellen.Name = "clmBestellen"
        Me.clmBestellen.ReadOnly = True
        Me.clmBestellen.Text = "Bestellen"
        Me.clmBestellen.UseColumnTextForButtonValue = True
        '
        'clmWunsch
        '
        Me.clmWunsch.HeaderText = "Wunsch"
        Me.clmWunsch.Name = "clmWunsch"
        Me.clmWunsch.ReadOnly = True
        Me.clmWunsch.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmWunsch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmWunsch.Text = "Wunsch"
        Me.clmWunsch.UseColumnTextForButtonValue = True
        '
        'FKKategorieSpeiseBindingSource
        '
        Me.FKKategorieSpeiseBindingSource.DataMember = "FK_Kategorie_Speise"
        Me.FKKategorieSpeiseBindingSource.DataSource = Me.FKRestaurantKategorieBindingSource
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKKategorieSpeiseBindingSource, "Beschreibung", True))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 290)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(557, 76)
        Me.TextBox1.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridView2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 375)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(711, 186)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.AnzahlDataGridViewTextBoxColumn, Me.clmAdd, Me.clmRemove, Me.GPreisDataGridViewTextBoxColumn, Me.clmLöschen})
        Me.DataGridView2.DataSource = Me.BestellungBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 40)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(705, 143)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Preis"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Preis"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Beachten"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Beachten"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'AnzahlDataGridViewTextBoxColumn
        '
        Me.AnzahlDataGridViewTextBoxColumn.DataPropertyName = "Anzahl"
        Me.AnzahlDataGridViewTextBoxColumn.HeaderText = "Anzahl"
        Me.AnzahlDataGridViewTextBoxColumn.Name = "AnzahlDataGridViewTextBoxColumn"
        Me.AnzahlDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnzahlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'clmAdd
        '
        Me.clmAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmAdd.HeaderText = "+"
        Me.clmAdd.Name = "clmAdd"
        Me.clmAdd.ReadOnly = True
        Me.clmAdd.Text = "+"
        Me.clmAdd.UseColumnTextForButtonValue = True
        Me.clmAdd.Width = 19
        '
        'clmRemove
        '
        Me.clmRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmRemove.HeaderText = "-"
        Me.clmRemove.Name = "clmRemove"
        Me.clmRemove.ReadOnly = True
        Me.clmRemove.Text = "-"
        Me.clmRemove.UseColumnTextForButtonValue = True
        Me.clmRemove.Width = 16
        '
        'GPreisDataGridViewTextBoxColumn
        '
        Me.GPreisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.GPreisDataGridViewTextBoxColumn.DataPropertyName = "GPreis"
        Me.GPreisDataGridViewTextBoxColumn.HeaderText = "GPreis"
        Me.GPreisDataGridViewTextBoxColumn.Name = "GPreisDataGridViewTextBoxColumn"
        Me.GPreisDataGridViewTextBoxColumn.ReadOnly = True
        Me.GPreisDataGridViewTextBoxColumn.Width = 63
        '
        'clmLöschen
        '
        Me.clmLöschen.HeaderText = "Löschen"
        Me.clmLöschen.Name = "clmLöschen"
        Me.clmLöschen.ReadOnly = True
        Me.clmLöschen.Text = "Löschen"
        Me.clmLöschen.UseColumnTextForButtonValue = True
        '
        'BestellungBindingSource
        '
        Me.BestellungBindingSource.DataMember = "Bestellung"
        Me.BestellungBindingSource.DataSource = Me.Essensplaner
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.lblPreis)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 31)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(333, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 31)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "EIGEN"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(243, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 31)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "SPEISEPLÄNE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(165, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 31)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "DRUCKEN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblPreis
        '
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreis.Location = New System.Drawing.Point(523, 1)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(98, 24)
        Me.lblPreis.TabIndex = 5
        Me.lblPreis.Text = "Kosten: 0€"
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(87, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "BESTELLEN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "BEARBEITEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Essensplaner"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Essensplaner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.FKRestaurantKategorieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKKategorieSpeiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestellungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeachtenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Essensplaner As Essensplaner
    Friend WithEvents RestaurantBindingSource As BindingSource
    Friend WithEvents FKRestaurantKategorieBindingSource As BindingSource
    Friend WithEvents FKKategorieSpeiseBindingSource As BindingSource
    Friend WithEvents BestellungBindingSource As BindingSource
    Friend WithEvents lblPreis As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents clmBestellen As DataGridViewButtonColumn
    Friend WithEvents clmWunsch As DataGridViewButtonColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents AnzahlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents clmAdd As DataGridViewButtonColumn
    Friend WithEvents clmRemove As DataGridViewButtonColumn
    Friend WithEvents GPreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents clmLöschen As DataGridViewButtonColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
