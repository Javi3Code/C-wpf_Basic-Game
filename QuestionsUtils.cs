using System.Collections.Generic;

namespace JCode.Games
{
    class QuestionsUtils
    {
        /**
         * Mapa donde se guardan las respuestas
         */
        public Dictionary<int, string> ResponseMap { get; set; }
        /**
         * Instancia a devolver
         */
        private static QuestionsUtils instance;
        /**
         * Constructor
         */
        private QuestionsUtils() => InitializeResponseMap();

        /**
         * Metodo para devolver la unica instancia de esta clase, implementando el patron Singleton.
         */
        public static QuestionsUtils GetInstance()
        {
            instance = instance == null ? new QuestionsUtils() : instance;
            return instance;
        }

        /**
         * Metodo para cargar las respuestas.
         */
        private void InitializeResponseMap()
        {
            ResponseMap = new Dictionary<int, string>();
            ResponseMap.Add(1, "Homero");
            ResponseMap.Add(2, "Sun Tzu");
            ResponseMap.Add(3, "Tomás Moro");
            ResponseMap.Add(4, "Herman Melville");
            ResponseMap.Add(5, "Siglo XVI");
            ResponseMap.Add(6, "Ortega y Gasset");
            ResponseMap.Add(7, "Antoine de Saint-Exupéry");
        }
    }
}
