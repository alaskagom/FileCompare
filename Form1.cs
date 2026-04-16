namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            try 
            {
                // [1] 실행하고싶은코드(오류가날가능성이있는곳)
                using (var dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "폴더를선택하세요.";
                    // 현재텍스트박스에있는경로를초기선택폴더로설정
                    if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) &&
                    Directory.Exists(txtLeftDir.Text))
                    {
                        dlg.SelectedPath = txtLeftDir.Text;
                    }
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        txtLeftDir.Text = dlg.SelectedPath;
                        PopulateListView(lvwLeftDir, dlg.SelectedPath);

                        // 우측 폴더도 선택되어 있다면 함께 갱신하여 색상 비교 적용
                        if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
                        {
                            PopulateListView(lvwrightDir, txtRightDir.Text);
                        }
                    }
                }
            }
            catch (Exception ex)  
            {
                // [2] 오류가발생했을때실행되는코드
                Console.WriteLine("오류발생: " + ex.Message);
            }
            finally 
            {
                // [3] 오류와상관없이무조건마지막에실행되는코드(생략가능)
            }
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            try 
            {
                // [1] 실행하고싶은코드(오류가날가능성이있는곳)
                using (var dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "폴더를선택하세요.";
                    // 현재텍스트박스에있는경로를초기선택폴더로설정
                    if (!string.IsNullOrWhiteSpace(txtRightDir.Text) &&
                    Directory.Exists(txtRightDir.Text))
                    {
                        dlg.SelectedPath = txtRightDir.Text;
                    }
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        txtRightDir.Text = dlg.SelectedPath;
                        PopulateListView(lvwrightDir, dlg.SelectedPath);

                        // 좌측 폴더도 선택되어 있다면 함께 갱신하여 색상 비교 적용
                        if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                        {
                            PopulateListView(lvwLeftDir, txtLeftDir.Text);
                        }
                    }

                }
            }
            catch (Exception ex)  
            {
                // [2] 오류가발생했을때실행되는코드
                Console.WriteLine("오류발생: " + ex.Message);
            }
            finally 
            {
                // [3] 오류와상관없이무조건마지막에실행되는코드(생략가능)
            }

        }

        private void lvwLeftDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListView(ListView lvw, string path)
        {
            lvw.Items.Clear();
            var dirInfo = new System.IO.DirectoryInfo(path);
            if (!dirInfo.Exists) return;

            foreach (var lf in dirInfo.GetFiles())
            {
                // 3단계: 사용자정의출력
                var litem = new ListViewItem(lf.Name);
                litem.SubItems.Add(FormatSizeInKb(lf.Length));
                litem.SubItems.Add(lf.LastWriteTime.ToString("g"));

                // 실제 맞은편 파일과 비교하여 rf 변수에 할당합니다.
                System.IO.FileInfo? rf = null;
                string otherDir = (lvw == lvwLeftDir) ? txtRightDir.Text : txtLeftDir.Text;
                
                if (!string.IsNullOrWhiteSpace(otherDir))
                {
                    string targetPath = System.IO.Path.Combine(otherDir, lf.Name);
                    if (System.IO.File.Exists(targetPath))
                    {
                        rf = new System.IO.FileInfo(targetPath);
                    }
                }

                // 상태결정및색상적용
                if (rf == null)
                {
                    // 한쪽에만 있는 경우
                    litem.ForeColor = Color.Purple;
                }
                else
                {
                    // 보여지는 시간(분 단위)과 크기가 완전히 같으면 검정색
                    if (lf.LastWriteTime.ToString("g") == rf.LastWriteTime.ToString("g") && lf.Length == rf.Length) 
                    {
                        // 2단계: 항목별색상설정
                        litem.ForeColor = Color.Black;
                    }
                    else if (lf.LastWriteTime < rf.LastWriteTime)
                    {
                        // 이전 파일인 경우
                        litem.ForeColor = Color.Gray;
                    }
                    else
                    {
                        // 최신 파일인 경우
                        litem.ForeColor = Color.Red;
                    }
                }

                lvw.Items.Add(litem);
            }
        }

        private string FormatSizeInKb(long length)
        {
            return (length / 1024.0).ToString("F2") + " KB";
        }

        // ListView색상처리
        // 1단계: DrawItem이벤트사용
        private void lvwLeftDir_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvwLeftDir_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvwLeftDir_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}

