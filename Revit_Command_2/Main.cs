using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.Creation;


namespace Revit_Command_2
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Получение объектов приложения и документа
            UIApplication uiapp = commandData.Application;
            Autodesk.Revit.DB.Document doc = uiapp.ActiveUIDocument.Document;

            //Создание диалогового окна Grids_Creator.
            Grids_Creator form = new Grids_Creator();
            form.ShowDialog();

            //Создание GridHor
            CreateHorGrid(doc, form.GridHorNumber, form.GridHorDistance);

            //Создание GridVer
            CreateVerGrid(doc, form.GridVerNumber, form.GridVerDistance);

            return Result.Succeeded;
        }
        private void CreateHorGrid (Autodesk.Revit.DB.Document doc, int number, double distance)
        {
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    using (Transaction tx = new Transaction(doc))
                    {
                        try
                        {
                            tx.Start("CreateHorGrid:" + i);
                            XYZ start = new XYZ(0, 0, 0);
                            XYZ end = new XYZ(0, 30, 0);
                            Line geomLine = Line.CreateBound(start, end);
                            Grid newGrid = Grid.Create(doc, geomLine);
                            newGrid.Name = (i).ToString();
                            tx.Commit();
                        }
                        catch (Exception ex)
                        {
                            TaskDialog.Show("Revit", (ex).ToString());
                            tx.RollBack();
                        }
                    }
                }
                else
                {
                    using (Transaction tx = new Transaction(doc))
                    {
                        try
                        {
                            tx.Start("CreateHorGrid:" + i);
                            XYZ start = new XYZ(i * distance, 0, 0);
                            XYZ end = new XYZ(i * distance, 30, 0);
                            Line geomLine = Line.CreateBound(start, end);
                            Grid newGrid = Grid.Create(doc, geomLine);
                            newGrid.Name = (i).ToString();
                        }
                        catch (Exception ex)
                        {
                            TaskDialog.Show("Revit", (ex).ToString());
                            tx.RollBack();
                        }
                    }
                }
            }
        }

        private void CreateVerGrid(Autodesk.Revit.DB.Document doc, int number, double distance)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    using (Transaction tx = new Transaction(doc))
                    {
                        try
                        {
                            tx.Start("CreateVerGrid:" + letters[i].ToString());
                            XYZ start = new XYZ(0, 0, 0);
                            XYZ end = new XYZ(30, 0, 0);
                            Line geomLine = Line.CreateBound(start, end);
                            Grid newGrid = Grid.Create(doc, geomLine);
                            newGrid.Name = letters[i].ToString();
                            tx.Commit();
                        }
                        catch (Exception ex)
                        {
                            TaskDialog.Show("Revit", (ex).ToString());
                            tx.RollBack();
                        }
                    }
                }
                else
                {
                    using (Transaction tx = new Transaction(doc))
                    {
                        try
                        {
                            tx.Start("CreateVerGrid:" + letters[i].ToString());
                            XYZ start = new XYZ(0, i * distance, 0);
                            XYZ end = new XYZ(30, i * distance, 0);
                            Line geomLine = Line.CreateBound(start, end);
                            Grid newGrid = Grid.Create(doc, geomLine);
                            newGrid.Name = letters[i].ToString();
                            tx.Commit();
                        }
                        catch (Exception ex)
                        {
                            TaskDialog.Show("Revit", (ex).ToString());
                            tx.RollBack();
                        }
                    }
                }
            }
        }
    }

}