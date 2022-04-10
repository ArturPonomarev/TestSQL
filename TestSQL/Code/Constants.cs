using System;
using System.Collections.Generic;


namespace TestSQL
{
    public enum DataState
    {
        AUTOMOBILE_STATE,
        ORDER_STATE,
        CLIENT_STATE,
    };
    
    public enum ManipulateDataStates
    {
        ADD_STATE,
        UPDATE_STATE
    };

    static class Data
    {
        //Текст
        public const string AUTOMOBILE_LABEL_TEXT = "Автомобили";
        public const string AUTOMOBILE_FIRSTCHECKBOX_TEXT = "ID";
        public const string AUTOMOBILE_SECONDCHECKBOX_TEXT = "МаркаМодель";
        public const string AUTOMOBILE_THIRDCHECKBOX_TEXT = "Состояние";

        public const string ORDER_LABEL_TEXT = "Заказы";
        public const string ORDER_FIRSTCHECKBOX_TEXT = "ID";
        public const string ORDER_SECONDCHECKBOX_TEXT = "Стоимость";
        public const string ORDER_THIRDCHECKBOX_TEXT = "Состояние";

        public const string CLIENT_LABEL_TEXT = "Клиенты";
        public const string CLIENT_FIRSTCHECKBOX_TEXT = "ID";
        public const string CLIENT_SECONDCHECKBOX_TEXT = "ФИО";
        public const string CLIENT_THIRDCHECKBOX_TEXT = "Телефон";

        //Цвета
        public static System.Drawing.Color COLOR_BUTTON_SELECT = System.Drawing.Color.FromArgb(0, 255, 255);
        public static System.Drawing.Color COLOR_BUTTON_ACTIVE = System.Drawing.Color.SkyBlue;
        public static System.Drawing.Color COLOR_BUTTON_UNACTIVE = System.Drawing.Color.SlateGray;

        #region Автомобили
        //Содержимое поля "Марка" в форме добавления автомобилей
        private static string[] SubaruModels =
        {
            "FORESTER",
            "IMPREZA",
            "OUTBACK"
        };
        private static string[] BmvModels =
        {
            "X1",
            "X3",
            "X6"
        };
        private static string[] FordModels =
        {
            "FIESTA",
            "FOCUS",
            "MUSTANG"
        };
        private static string[] LadaModels =
        {
            "VESTA",
            "GRANTA",
            "KALINA"
        };
        private static string[] AudiModels =
        {
            "A1",
            "SQ8",
            "S7"
        };

        public static Dictionary<string, string[]> MarkaModel = new Dictionary<string, string[]>()
        {
            ["SUBARU"] = SubaruModels,
            ["AUDI"] = AudiModels,
            ["LADA"] = LadaModels,
            ["FORD"] = FordModels,
            ["BMW"] = BmvModels,
        };
        #endregion

        //Состояния заказов
        public static string[] OrderStates =
        {
            "Выполняется",
            "Выполнен",
            "Провален",
            "Отменен"
        };

        //Состояния автомобилей
        public static string[] AutomobileStates =
        {
            "Стоит",
            "Движется",
            "Ожидает ремонта",
            "На ремонте",
            "Не активен",
            "Списан"
        };


        #region Названия полей в таблицах
        public static string[] AutomobileFields =
        {
            "id",
            "marka",
            "model",
            "capacity",
            "color",
            "number",
            "type",
            "state"
        };

        public static string[] OrderFields =
        {
            "id",
            "price",
            "state",
            "automobile_id_automobile",
            "Cleints_id_client",
            "t_start",
            "t_end"
        };

        public static string[] ClientsFields =
        {
            "id",
            "FIO",
            "phone_number"
        };
        #endregion

        public const string TABLENAME_AUTO = "automobile";
        public const string TABLENAME_ORDERS = "orders";
        public const string TABLENAME_CLIENTS = "cleints";
    }
}
