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


        protected virtual void infoAdded(String info)
        {
            if (OnInfo != null)
                OnInfo(this, info);
        }

        protected virtual void errorAdded(String info)
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
        public void addInfo(String informacao)
        {
            infoAdded(informacao);
        }

        /// <summary>
        /// Adiciona uma informação ao validador.
        /// </summary>
        /// <param name="infotype">Tipo de informação.</param>
        /// <param name="related">Objeto relacionado.</param>
        public void addInfo(String informacao, object related)
        {
            informacao += " - " + related;
            infoAdded(informacao);
        }

        /// <summary>
        /// Adiciona um erro ao validador.
        /// </summary>
        /// <param name="info">Tipo de informação do erro</param>
        public void addError(String erro)
        {
            if (!errorList.Contains(erro))
                errorList.Add(erro);
            errorAdded(erro);
        }

        /// <summary>
        /// Adiciona um erro ao validador.
        /// </summary>
        /// <param name="infotype">Tipo de informação do erro</param>
        /// <param name="related">Objeto relacionado</param>
        public void addError(String erro, object related)
        {
            erro += " - " + related;
            if (!errorList.Contains(erro))
                errorList.Add(erro);
            errorAdded(erro);
        }

        /// <summary>
        /// Retorna uma coleção de erros do validador.
        /// </summary>
        /// <returns>Retorna os erros do validador</returns>
        public IList<String> getErrors()
        {
            return errorList;
        }

        public bool containsErrors()
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
