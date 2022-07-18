using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Air
{
    class ExportExcel
    {
        private HSSFWorkbook workBook;
        private ISheet workSheet;

        public ExportExcel(string name)
        {
            InitialWorkBook(name);
        }
        


        #region 创建与保存工作簿和表格

        private void InitialWorkBook(string sheetName)
        {
            workBook = new HSSFWorkbook();
            workSheet = workBook.CreateSheet(sheetName);

        }


        /// <summary>
        /// 保存文件到指定位置（待优化）
        /// </summary>
        /// <param name="workBook">要保存的文件</param>
        /// <param name="path">文件路径</param>
        /// <param name="fileName">文件名称</param>
        private void SaveWorkBook(IWorkbook workBook,string path,string fileName)
        {
            string fullPath = path + "\\"+fileName;
            FileStream file = new FileStream(fullPath, FileMode.Create);
            try
                {workBook.Write(file); }
            catch (Exception)
                {throw;}
            finally
                {file.Close();}
        }
        #endregion
    }
}
