using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFMVC.Validation
{
    /// <summary>
    /// Gerenciador de eventos do validador.
    /// </summary>
    /// <param name="sender">Validador instanciado</param>
    /// <param name="eventInfo">Informação do evento</param>
    public delegate void ValidatorEventHandler (Validator sender, String eventInfo);
    public delegate void ValidatorClearEventHandler (Validator sender);
    /// <summary>
    /// Validador padrão
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Evento de adição de informações.
        /// </summary>
        public event ValidatorEventHandler OnInfo;
        /// <summary>
        /// Evento de adição de erros.
        /// </summary>
        public event ValidatorEventHandler OnError;
        /// <summary>
        /// Evento de limpeza do validator.
        /// </summary>
        public event ValidatorClearEventHandler OnValidatorCleansed;
        /// <summary>
        /// Invoca o evento de adição de informações.
        /// </summary>
        /// <param name="info"></param>
        protected virtual void InfoAdded(String info)
        {
            if (OnInfo != null)
                OnInfo(this, info);
        }
        /// <summary>
        /// Invoca o evento de adição de erros.
        /// </summary>
        /// <param name="info"></param>
        protected virtual void ErrorAdded(String info)
        {
            if (OnError != null)
                OnError(this, info);
        }
        /// <summary>
        /// Container de erros.
        /// </summary>
        IList<String> errorList = new List<String>();

        /// <summary>
        /// Adiciona uma informação ao validador.
        /// </summary>
        /// <param name="informacao">Tipo de informação.</param>
        public void AddInfo(String informacao)
        {
            InfoAdded(informacao);
        }

        /// <summary>
        /// Adiciona uma informação ao validador.
        /// </summary>
        /// <param name="infotype">Tipo de informação.</param>
        /// <param name="related">Objeto relacionado.</param>
        public void AddInfo(String informacao, object related)
        {
            informacao += " - " + related;
            InfoAdded(informacao);
        }

        /// <summary>
        /// Adiciona um erro ao validador.
        /// </summary>
        /// <param name="info">Tipo de informação do erro</param>
        public void AddError(String erro)
        {
            if (!errorList.Contains(erro))
                errorList.Add(erro);
            ErrorAdded(erro);
        }

        /// <summary>
        /// Adiciona um erro ao validador.
        /// </summary>
        /// <param name="infotype">Tipo de informação do erro</param>
        /// <param name="related">Objeto relacionado</param>
        public void AddError(String erro, object related)
        {
            erro += " - " + related;
            if (!errorList.Contains(erro))
                errorList.Add(erro);
            ErrorAdded(erro);
        }

        /// <summary>
        /// Retorna uma coleção de erros do validador.
        /// </summary>
        /// <returns>Retorna os erros do validador</returns>
        public IList<String> GetErrors()
        {
            return errorList;
        }

        /// <summary>
        /// Informa se o validador contém erros.
        /// </summary>
        /// <returns></returns>
        public bool ContainsErrors()
        {
            return errorList.Count > 0;
        }

        /// <summary>
        /// Remove os erros do validador.
        /// </summary>
        public void Clear()
        {
            if (OnValidatorCleansed != null)
                OnValidatorCleansed(this);
            errorList.Clear();
        }
    }
}
