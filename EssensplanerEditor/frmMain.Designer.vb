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
        Me.Essensplaner1 = New EssensplanerEditor.Essensplaner()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RestaurantDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestaurantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKRestaurantKategorieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreisDataGridViewTextBoxColumn = New EssensplanerEditor.NumericUpDownColumn()
        Me.FKKategorieSpeiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKRestaurantKategorieBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.Essensplaner1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.RestaurantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKRestaurantKategorieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKKategorieSpeiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKRestaurantKategorieBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Essensplaner1
        '
        Me.Essensplaner1.DataSetName = "Essensplaner"
        Me.Essensplaner1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(567, 367)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.RestaurantDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(559, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Restaurant"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RestaurantDataGridView
        '
        Me.RestaurantDataGridView.AutoGenerateColumns = False
        Me.RestaurantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RestaurantDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.BeschreibungDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn})
        Me.RestaurantDataGridView.DataSource = Me.RestaurantBindingSource
        Me.RestaurantDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RestaurantDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.RestaurantDataGridView.Name = "RestaurantDataGridView"
        Me.RestaurantDataGridView.Size = New System.Drawing.Size(553, 335)
        Me.RestaurantDataGridView.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'BeschreibungDataGridViewTextBoxColumn
        '
        Me.BeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.Name = "BeschreibungDataGridViewTextBoxColumn"
        '
        'StraßeDataGridViewTextBoxColumn
        '
        Me.StraßeDataGridViewTextBoxColumn.DataPropertyName = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.HeaderText = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.Name = "StraßeDataGridViewTextBoxColumn"
        '
        'PlzDataGridViewTextBoxColumn
        '
        Me.PlzDataGridViewTextBoxColumn.DataPropertyName = "Plz"
        Me.PlzDataGridViewTextBoxColumn.HeaderText = "Plz"
        Me.PlzDataGridViewTextBoxColumn.Name = "PlzDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'RestaurantBindingSource
        '
        Me.RestaurantBindingSource.DataMember = "Restaurant"
        Me.RestaurantBindingSource.DataSource = Me.Essensplaner1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(559, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kategorie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.BeschreibungDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.FKRestaurantKategorieBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(123, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(433, 268)
        Me.DataGridView1.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'BeschreibungDataGridViewTextBoxColumn1
        '
        Me.BeschreibungDataGridViewTextBoxColumn1.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn1.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn1.Name = "BeschreibungDataGridViewTextBoxColumn1"
        '
        'FKRestaurantKategorieBindingSource
        '
        Me.FKRestaurantKategorieBindingSource.DataMember = "FK_Restaurant_Kategorie"
        Me.FKRestaurantKategorieBindingSource.DataSource = Me.RestaurantBindingSource1
        '
        'RestaurantBindingSource1
        '
        Me.RestaurantBindingSource1.DataMember = "Restaurant"
        Me.RestaurantBindingSource1.DataSource = Me.Essensplaner1
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.RestaurantBindingSource1
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 335)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ID"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Controls.Add(Me.ListBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(559, 341)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Speise"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn2, Me.BeschreibungDataGridViewTextBoxColumn2, Me.PreisDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.FKKategorieSpeiseBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.Location = New System.Drawing.Point(243, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(313, 277)
        Me.DataGridView2.TabIndex = 2
        '
        'NameDataGridViewTextBoxColumn2
        '
        Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
        '
        'BeschreibungDataGridViewTextBoxColumn2
        '
        Me.BeschreibungDataGridViewTextBoxColumn2.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn2.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn2.Name = "BeschreibungDataGridViewTextBoxColumn2"
        '
        'PreisDataGridViewTextBoxColumn
        '
        Me.PreisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PreisDataGridViewTextBoxColumn.DataPropertyName = "Preis"
        Me.PreisDataGridViewTextBoxColumn.HeaderText = "Preis"
        Me.PreisDataGridViewTextBoxColumn.Name = "PreisDataGridViewTextBoxColumn"
        Me.PreisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PreisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PreisDataGridViewTextBoxColumn.Width = 55
        '
        'FKKategorieSpeiseBindingSource
        '
        Me.FKKategorieSpeiseBindingSource.DataMember = "FK_Kategorie_Speise"
        Me.FKKategorieSpeiseBindingSource.DataSource = Me.FKRestaurantKategorieBindingSource1
        '
        'FKRestaurantKategorieBindingSource1
        '
        Me.FKRestaurantKategorieBindingSource1.DataMember = "FK_Restaurant_Kategorie"
        Me.FKRestaurantKategorieBindingSource1.DataSource = Me.RestaurantBindingSource2
        '
        'RestaurantBindingSource2
        '
        Me.RestaurantBindingSource2.DataMember = "Restaurant"
        Me.RestaurantBindingSource2.DataSource = Me.Essensplaner1
        '
        'ListBox3
        '
        Me.ListBox3.DataSource = Me.FKRestaurantKategorieBindingSource1
        Me.ListBox3.DisplayMember = "Name"
        Me.ListBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(123, 3)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 335)
        Me.ListBox3.TabIndex = 1
        Me.ListBox3.ValueMember = "ID"
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.RestaurantBindingSource2
        Me.ListBox2.DisplayMember = "Name"
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 335)
        Me.ListBox2.TabIndex = 0
        Me.ListBox2.ValueMember = "ID"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKKategorieSpeiseBindingSource, "Beschreibung", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(243, 280)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(313, 58)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKRestaurantKategorieBindingSource, "Beschreibung", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(123, 271)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(433, 67)
        Me.TextBox2.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 367)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Essensplaner Editor"
        CType(Me.Essensplaner1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.RestaurantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKRestaurantKategorieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKKategorieSpeiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKRestaurantKategorieBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Essensplaner1 As Essensplaner
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RestaurantDataGridView As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestaurantBindingSource As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FKRestaurantKategorieBindingSource As BindingSource
    Friend WithEvents RestaurantBindingSource1 As BindingSource
    Friend WithEvents FKKategorieSpeiseBindingSource As BindingSource
    Friend WithEvents FKRestaurantKategorieBindingSource1 As BindingSource
    Friend WithEvents RestaurantBindingSource2 As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PreisDataGridViewTextBoxColumn As NumericUpDownColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
