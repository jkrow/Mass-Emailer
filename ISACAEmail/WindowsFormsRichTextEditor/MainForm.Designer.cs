namespace WindowsFormsRichTextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemOpenSample1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenSample2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenSample3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenSample4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenSample5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGemBoxCut = new System.Windows.Forms.ToolStripButton();
            this.btnGemBoxCopy = new System.Windows.Forms.ToolStripButton();
            this.btnGemBoxPastePrepend = new System.Windows.Forms.ToolStripButton();
            this.btnGemBoxPasteAppend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this.btnDecreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToggleBullets = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDecreaseIndentation = new System.Windows.Forms.ToolStripButton();
            this.btnIncreaseIndentation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.btnAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.btnAlignRight = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.txtAttach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnGemBoxCut,
            this.btnGemBoxCopy,
            this.btnGemBoxPastePrepend,
            this.btnGemBoxPasteAppend,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator3,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator4,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.toolStripSeparator5,
            this.btnIncreaseFontSize,
            this.btnDecreaseFontSize,
            this.toolStripSeparator6,
            this.btnToggleBullets,
            this.toolStripSeparator7,
            this.btnDecreaseIndentation,
            this.btnIncreaseIndentation,
            this.toolStripSeparator8,
            this.btnAlignLeft,
            this.btnAlignCenter,
            this.btnAlignRight});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(824, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "ToolBar";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.toolStripSeparator9,
            this.menuItemOpenSample1,
            this.menuItemOpenSample2,
            this.menuItemOpenSample3,
            this.menuItemOpenSample4,
            this.menuItemOpenSample5});
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(29, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.ToolTipText = "Open";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpen.Text = "Open ...";
            this.menuItemOpen.ToolTipText = "Open a file";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(215, 6);
            // 
            // menuItemOpenSample1
            // 
            this.menuItemOpenSample1.Name = "menuItemOpenSample1";
            this.menuItemOpenSample1.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpenSample1.Tag = "1";
            this.menuItemOpenSample1.Text = "Character Formatting.docx";
            this.menuItemOpenSample1.ToolTipText = "Open Character Formatting.docx";
            this.menuItemOpenSample1.Click += new System.EventHandler(this.menuItemOpenSample_Click);
            // 
            // menuItemOpenSample2
            // 
            this.menuItemOpenSample2.Name = "menuItemOpenSample2";
            this.menuItemOpenSample2.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpenSample2.Tag = "2";
            this.menuItemOpenSample2.Text = "Paragraph Formatting.docx";
            this.menuItemOpenSample2.ToolTipText = "Open Paragraph Formatting.docx";
            this.menuItemOpenSample2.Click += new System.EventHandler(this.menuItemOpenSample_Click);
            // 
            // menuItemOpenSample3
            // 
            this.menuItemOpenSample3.Name = "menuItemOpenSample3";
            this.menuItemOpenSample3.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpenSample3.Tag = "3";
            this.menuItemOpenSample3.Text = "Lists.docx";
            this.menuItemOpenSample3.ToolTipText = "Open Lists.docx";
            this.menuItemOpenSample3.Click += new System.EventHandler(this.menuItemOpenSample_Click);
            // 
            // menuItemOpenSample4
            // 
            this.menuItemOpenSample4.Name = "menuItemOpenSample4";
            this.menuItemOpenSample4.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpenSample4.Tag = "4";
            this.menuItemOpenSample4.Text = "Style Resolution.docx";
            this.menuItemOpenSample4.ToolTipText = "Open Style Resolution.docx";
            this.menuItemOpenSample4.Click += new System.EventHandler(this.menuItemOpenSample_Click);
            // 
            // menuItemOpenSample5
            // 
            this.menuItemOpenSample5.Name = "menuItemOpenSample5";
            this.menuItemOpenSample5.Size = new System.Drawing.Size(218, 22);
            this.menuItemOpenSample5.Tag = "5";
            this.menuItemOpenSample5.Text = "Simple Table.docx";
            this.menuItemOpenSample5.ToolTipText = "Open Simple Table.docx";
            this.menuItemOpenSample5.Click += new System.EventHandler(this.menuItemOpenSample_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.ToolTipText = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGemBoxCut
            // 
            this.btnGemBoxCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGemBoxCut.Image = ((System.Drawing.Image)(resources.GetObject("btnGemBoxCut.Image")));
            this.btnGemBoxCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGemBoxCut.Name = "btnGemBoxCut";
            this.btnGemBoxCut.Size = new System.Drawing.Size(23, 22);
            this.btnGemBoxCut.Text = "toolStripButton1";
            this.btnGemBoxCut.ToolTipText = "Cut with GemBox.Document";
            this.btnGemBoxCut.Click += new System.EventHandler(this.btnGemBoxCut_Click);
            // 
            // btnGemBoxCopy
            // 
            this.btnGemBoxCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGemBoxCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnGemBoxCopy.Image")));
            this.btnGemBoxCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGemBoxCopy.Name = "btnGemBoxCopy";
            this.btnGemBoxCopy.Size = new System.Drawing.Size(23, 22);
            this.btnGemBoxCopy.Text = "toolStripButton1";
            this.btnGemBoxCopy.ToolTipText = "Copy with GemBox.Document";
            this.btnGemBoxCopy.Click += new System.EventHandler(this.btnGemBoxCopy_Click);
            // 
            // btnGemBoxPastePrepend
            // 
            this.btnGemBoxPastePrepend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGemBoxPastePrepend.Image = ((System.Drawing.Image)(resources.GetObject("btnGemBoxPastePrepend.Image")));
            this.btnGemBoxPastePrepend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGemBoxPastePrepend.Name = "btnGemBoxPastePrepend";
            this.btnGemBoxPastePrepend.Size = new System.Drawing.Size(23, 22);
            this.btnGemBoxPastePrepend.Text = "toolStripButton1";
            this.btnGemBoxPastePrepend.ToolTipText = "Paste prepend with GemBox.Document";
            this.btnGemBoxPastePrepend.Click += new System.EventHandler(this.btnGemBoxPastePrepend_Click);
            // 
            // btnGemBoxPasteAppend
            // 
            this.btnGemBoxPasteAppend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGemBoxPasteAppend.Image = ((System.Drawing.Image)(resources.GetObject("btnGemBoxPasteAppend.Image")));
            this.btnGemBoxPasteAppend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGemBoxPasteAppend.Name = "btnGemBoxPasteAppend";
            this.btnGemBoxPasteAppend.Size = new System.Drawing.Size(23, 22);
            this.btnGemBoxPasteAppend.Text = "toolStripButton1";
            this.btnGemBoxPasteAppend.ToolTipText = "Paste append with GemBox.Document";
            this.btnGemBoxPasteAppend.Click += new System.EventHandler(this.btnGemBoxPasteAppend_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(130, 22);
            this.toolStripLabel2.Text = "Window Forms ToolBar";
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "toolStripButton1";
            this.btnUndo.ToolTipText = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "toolStripButton1";
            this.btnRedo.ToolTipText = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCut
            // 
            this.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(23, 22);
            this.btnCut.Text = "toolStripButton1";
            this.btnCut.ToolTipText = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.Text = "toolStripButton1";
            this.btnCopy.ToolTipText = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.Text = "toolStripButton1";
            this.btnPaste.ToolTipText = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "B";
            this.btnBold.ToolTipText = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItalic.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "I";
            this.btnItalic.ToolTipText = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnderline.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "U";
            this.btnUnderline.ToolTipText = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnIncreaseFontSize
            // 
            this.btnIncreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreaseFontSize.Image")));
            this.btnIncreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncreaseFontSize.Name = "btnIncreaseFontSize";
            this.btnIncreaseFontSize.Size = new System.Drawing.Size(23, 22);
            this.btnIncreaseFontSize.Text = "toolStripButton1";
            this.btnIncreaseFontSize.ToolTipText = "Increase Font Size";
            this.btnIncreaseFontSize.Click += new System.EventHandler(this.btnIncreaseFontSize_Click);
            // 
            // btnDecreaseFontSize
            // 
            this.btnDecreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDecreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseFontSize.Image")));
            this.btnDecreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDecreaseFontSize.Name = "btnDecreaseFontSize";
            this.btnDecreaseFontSize.Size = new System.Drawing.Size(23, 22);
            this.btnDecreaseFontSize.Text = "toolStripButton1";
            this.btnDecreaseFontSize.ToolTipText = "Decrease Font Size";
            this.btnDecreaseFontSize.Click += new System.EventHandler(this.btnDecreaseFontSize_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnToggleBullets
            // 
            this.btnToggleBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToggleBullets.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleBullets.Image")));
            this.btnToggleBullets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleBullets.Name = "btnToggleBullets";
            this.btnToggleBullets.Size = new System.Drawing.Size(23, 22);
            this.btnToggleBullets.Text = "toolStripButton1";
            this.btnToggleBullets.ToolTipText = "Bullets";
            this.btnToggleBullets.Click += new System.EventHandler(this.btnToggleBullets_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDecreaseIndentation
            // 
            this.btnDecreaseIndentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDecreaseIndentation.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseIndentation.Image")));
            this.btnDecreaseIndentation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDecreaseIndentation.Name = "btnDecreaseIndentation";
            this.btnDecreaseIndentation.Size = new System.Drawing.Size(23, 22);
            this.btnDecreaseIndentation.Text = "toolStripButton1";
            this.btnDecreaseIndentation.ToolTipText = "Decrease Indentation";
            this.btnDecreaseIndentation.Click += new System.EventHandler(this.btnDecreaseIndentation_Click);
            // 
            // btnIncreaseIndentation
            // 
            this.btnIncreaseIndentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncreaseIndentation.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreaseIndentation.Image")));
            this.btnIncreaseIndentation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncreaseIndentation.Name = "btnIncreaseIndentation";
            this.btnIncreaseIndentation.Size = new System.Drawing.Size(23, 22);
            this.btnIncreaseIndentation.Text = "toolStripButton1";
            this.btnIncreaseIndentation.ToolTipText = "Increase Indentation";
            this.btnIncreaseIndentation.Click += new System.EventHandler(this.btnIncreaseIndentation_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignLeft.Image")));
            this.btnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.btnAlignLeft.Text = "toolStripButton1";
            this.btnAlignLeft.ToolTipText = "Align Left";
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignCenter.Image")));
            this.btnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.btnAlignCenter.Text = "toolStripButton1";
            this.btnAlignCenter.ToolTipText = "Align Center";
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignRight.Image")));
            this.btnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(23, 22);
            this.btnAlignRight.Text = "toolStripButton1";
            this.btnAlignRight.ToolTipText = "Align Right";
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 25);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(824, 379);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(650, 445);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(421, 496);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(25, 496);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(378, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter or select address file:";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(421, 548);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 13;
            this.btnAttach.Text = "Browse";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAttach
            // 
            this.txtAttach.Location = new System.Drawing.Point(25, 548);
            this.txtAttach.Name = "txtAttach";
            this.txtAttach.Size = new System.Drawing.Size(378, 20);
            this.txtAttach.TabIndex = 12;
            this.txtAttach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter or select files for attaching:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter email address ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 445);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(378, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(650, 493);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Reset/Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Red;
            this.btnConfig.Location = new System.Drawing.Point(650, 548);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(90, 23);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtAttach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ISACA Of Madison Mass Email Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGemBoxCut;
        private System.Windows.Forms.ToolStripButton btnGemBoxCopy;
        private System.Windows.Forms.ToolStripButton btnGemBoxPastePrepend;
        private System.Windows.Forms.ToolStripButton btnGemBoxPasteAppend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripButton btnIncreaseFontSize;
        private System.Windows.Forms.ToolStripButton btnDecreaseFontSize;
        private System.Windows.Forms.ToolStripButton btnToggleBullets;
        private System.Windows.Forms.ToolStripButton btnDecreaseIndentation;
        private System.Windows.Forms.ToolStripButton btnIncreaseIndentation;
        private System.Windows.Forms.ToolStripButton btnAlignLeft;
        private System.Windows.Forms.ToolStripButton btnAlignCenter;
        private System.Windows.Forms.ToolStripButton btnAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripDropDownButton btnOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSample1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSample2;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSample3;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSample4;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSample5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.TextBox txtAttach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfig;
    }
}

