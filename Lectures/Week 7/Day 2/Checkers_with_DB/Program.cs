using CheckersGame.Model;
using CheckersGame.Enum;

namespace Checkers_with_DB;

partial class Program
{
    static string alphabet = "abcdefghijklmnopqrstuvwxyz";
    static string numbers = "0123456789";

    static void Main(string[] args)
    {
        Checkers db = new Checkers();
        Print(db.Database.ProviderName);
        MenuProgram();
    }

    private static void MenuProgram()
    {
        string? input;
        bool isValidInput = false;
        Clear();

        while (!isValidInput)
        {
            Print("========== Welcome to Checkers Database ==========");
            Print("Select from options below: ");
            Print("1] Read All Data from a table at Database");
            Print("2] Create New Data to a table at Database");
            Print("3] Update Data of a table at Database");
            Print("4] Delete Data of a table from Database");
            Print("0] Quit");

            Console.Write("Enter a command: ");
            input = GetInput();

            switch (input)
            {
                case "1":
                    ReadDatas();
                    break;
                case "2":
                    CreateDatas();
                    break;
                case "3":
                    UpdateDatas();
                    break;
                case "4":
                    // DeleteDatas();
                    Print("Delete Still on Development");
                    Print("");
                    break;
                case "0":
                    isValidInput = true;
                    break;
                default:
                    Print("Invalid input! Please try again.");
                    break;
            }
        }
    }

    private static void ReadDatas()
    {
        string? input;
        bool isValidInput = false;
        Clear();

        while (!isValidInput)
        {
            Print("========== Read Checkers Database ==========");
            Print("Select from options below: ");
            Print("1] Read All Data from Players Table");
            Print("2] Read All Data from Positions Table");
            Print("3] Read All Data from Ranks Table");
            Print("4] Read All Data from Colors Table");
            Print("5] Read All Data from Pieces Table");
            Print("99] Back");

            Console.Write("Enter a command: ");
            input = GetInput();

            switch (input)
            {
                case "1":
                    ReadPlayersData();
                    break;
                case "2":
                    ReadPositionsData();
                    break;
                case "3":
                    ReadRanksData();
                    break;
                case "4":
                    ReadColorsData();
                    break;
                case "5":
                    ReadPiecesData();
                    break;
                case "99":
                    isValidInput = true;
                    break;
                default:
                    Print("Invalid input! Please try again.");
                    break;
            }
        }
    }

    private static void CreateDatas()
    {
        string? input;
        bool isValidInput = false;
        Clear();

        while (!isValidInput)
        {
            Print("==========Read Checkers Database==========");
            Print("Select from options below: ");
            Print("1] Create New Data at Players Table");
            Print("2] Create New Data at Positions Table");
            Print("3] Create New Data at Ranks Table");
            Print("4] Create New Data at Colors Table");
            Print("5] Create New Data at Pieces Table");
            Print("99] Back");

            Console.Write("Enter a command: ");
            input = GetInput();

            switch (input)
            {
                case "1":
                    CreatePlayersData();
                    break;
                case "2":
                    CreatePositionsData();
                    break;
                case "3":
                    CreateRanksData();
                    break;
                case "4":
                    CreateColorsData();
                    break;
                case "5":
                    CreatePiecesData();
                    break;
                case "99":
                    isValidInput = true;
                    break;
                default:
                    Print("Invalid input! Please try again.");
                    break;
            }
        }
    }

    static void UpdateDatas()
    {
        string? input;
        bool isValidInput = false;
        Clear();

        while (!isValidInput)
        {
            Print("==========Read Checkers Database==========");
            Print("Select from options below: ");
            Print("1] Update Data at Players Table");
            Print("2] Update Data at Positions Table");
            Print("3] Update Data at Ranks Table");
            Print("4] Update Data at Colors Table");
            Print("5] Update Data at Pieces Table");
            Print("99] Back");

            Console.Write("Enter a command: ");
            input = GetInput();

            switch (input)
            {
                case "1":
                    UpdatePlayersData();
                    break;
                case "2":
                    UpdatePositionsData();
                    break;
                case "3":
                    UpdateRanksData();
                    break;
                case "4":
                    UpdateColorsData();
                    break;
                case "5":
                    UpdatePiecesData();
                    break;
                case "99":
                    isValidInput = true;
                    MenuProgram();
                    break;
                default:
                    Print("Invalid input! Please try again.");
                    break;
            }
        }
    }

    // static void DeleteDatas()
    // {
    //     string? input;
    //     bool isValidInput = false;
    //     Clear();

    //     while (!isValidInput)
    //     {
    //         Print("==========Read Checkers Database==========");
    //         Print("Select from options below: ");
    //         Print("1] Delete Data from Players Table");
    //         Print("2] Delete Data from Positions Table");
    //         Print("3] Delete Data from Ranks Table");
    //         Print("4] Delete Data from Colors Table");
    //         Print("5] Delete Data from Pieces Table");
    //         Print("99] Back");

    //         Console.Write("Enter a command: ");
    //         input = GetInput();

    //         switch (input)
    //         {
    //             case "1":
    //                 DeletePlayersData();
    //                 break;
    //             case "2":
    //                 DeletePositionsData();
    //                 break;
    //             case "3":
    //                 DeleteRanksData();
    //                 break;
    //             case "4":
    //                 DeleteColorsData();
    //                 break;
    //             case "5":
    //                 DeletePiecesData();
    //                 break;
    //             case "99":
    //                 isValidInput = true;
    //                 break;
    //             default:
    //                 Print("Invalid input! Please try again.");
    //                 break;
    //         }
    //     }
    // }

}