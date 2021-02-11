using Module10.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module10.Tasks
{
    public static class Task24
    {
        public static void ExecuteTask()
        {
            var tableDataList = new List<TableModel>() 
            { 
                new TableModel{Name="Artyom", Age=19},
                new TableModel{Name="Dima", Age=14},
                new TableModel{SurName="Kolosov", Age=100},
                new TableModel{Name = "Ilya", SurName="Kolosov"},
            };
            var table = new Table<TableModel>(tableDataList) 
            {
                TableHeader = "|  Id  |  Name  |  Surname  |  Age  |" 
            };
            Console.WriteLine(table);
        }
    }
}
