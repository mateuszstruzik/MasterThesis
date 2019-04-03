using magisterka._10TablesDB;
using magisterka._20TablesDB;
using magisterka._40TablesDB;
using magisterka._80TablesDB;
using System;

namespace magisterka
{
    class Program
    {
        public static DeleteAndInsertDB10 deleteAndInsertDB10 = new DeleteAndInsertDB10();
        public static InnerJoinFromDB10 innerJoinFromDB10 = new InnerJoinFromDB10();
        public static OuterJoinFromDB10 outerJoinFromDB10 = new OuterJoinFromDB10();
        public static SelectAllTablesFromDB10 selectAllTablesFromDB10 = new SelectAllTablesFromDB10();
        public static UpdateDB10 updateDB10 = new UpdateDB10();

        public static DeleteAndInsertDB20 deleteAndInsertDB20 = new DeleteAndInsertDB20();
        public static InnerJoinFromDB20 innerJoinFromDB20 = new InnerJoinFromDB20();
        public static OuterJoinFromDB20 outerJoinFromDB20 = new OuterJoinFromDB20();
        public static SelectAllTablesFromDB20 selectAllTablesFromDB20 = new SelectAllTablesFromDB20();
        public static UpdateDB20 updateDB20 = new UpdateDB20();

        public static DeleteAndInsertDB40 deleteAndInsertDB40 = new DeleteAndInsertDB40();
        public static OuterJoinFromDB40 outerJoinFromDB40 = new OuterJoinFromDB40();
        public static SelectAllTablesFromDB40 selectAllTablesFromDB40 = new SelectAllTablesFromDB40();
        public static UpdateDB40 updateDB40 = new UpdateDB40();

        public static DeleteAndInsertDB80 deleteAndInsertDB80 = new DeleteAndInsertDB80();
        public static OuterJoinFromDB80 outerJoinFromDB80 = new OuterJoinFromDB80();
        public static SelectAllTablesFromDB80 selectAllTablesFromDB80 = new SelectAllTablesFromDB80();
        public static UpdateDB80 updateDB80 = new UpdateDB80();

        /// ////////insert 


        static void Main(string[] args)
        {
            deleteAndInsertDB40.RunUpdateTest(3);
                
            Console.ReadKey();
        }
    }
}
