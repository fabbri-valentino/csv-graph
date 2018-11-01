using CSVGraph.Logger;
using CSVGraph.Directories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace CSVGraph.RegistryManager
{
    public static class ManageData
    {
        /// <summary>
        /// Imposto una chiave specifica all'interno del registro fornendo:
        /// </summary>
        /// <param name="key">il percorso della chiave</param>
        /// <param name="keyName">il nome della chiave</param>
        /// <param name="keyValue">il valore della chiave</param>
        /// <returns>
        /// TRUE - se la chiave esiste oppure viene creata.
        /// FALSE - se si sono verificate eccezioni. 
        /// </returns>
        public static bool SetKey(string key, bool setValue, string keyName = "", object keyValue = default)
        {
            try
            {
                if (setValue == true)
                {
                    if (KeyExist(key) == true)
                    {
                        AccessKey().OpenSubKey(key, true).SetValue(keyName, keyValue);
                        return true;
                    }
                    else
                    {
                        AccessKey().CreateSubKey(key).SetValue(keyName, keyValue);
                        return true;
                    }
                }
                else
                {
                    if (KeyExist(key) == true)
                    {
                        AccessKey().OpenSubKey(key, true);
                        return true;
                    }
                    else
                    {
                        AccessKey().CreateSubKey(key);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionWriter ew = new ExceptionWriter();
                string[] exArray = { "BEGIN "+ e.HResult +" MESSAGE",
                    DateTime.Now.ToString("r") + " - Messaggio: " + e.Message,
                    "END "+ e.HResult +" EXCEPTION" };
                IEnumerable<string> content = exArray;
                ew.Write(ErrorTypes.Exceptions, content);
                return false;
            }
        }
        /// <summary>
        /// Ottengo una stringa contenente il valore della chiave specificata
        /// </summary>
        /// <param name="key">Il percorso della chiave</param>
        /// <param name="keyName">Il nome della chiave</param>
        /// <returns>Ritorna la stringa della chiave oppure delle stringhe di default in caso d'errore</returns>
        public static string GetKeyValue(string key, string keyName)
        {
            try
            {
                if (KeyExist(key) == true)
                {
                    var result = AccessKey().OpenSubKey(key).GetValue(keyName).ToString();
                    return result;
                }
                else
                {
                    return "La chiave non è stata trovata";
                }
            }
            catch (Exception e)
            {
                ExceptionWriter ew = new ExceptionWriter();
                string[] exArray = { "BEGIN "+ e.HResult +" MESSAGE",
                    DateTime.Now.ToString("r") + " - Messaggio: " + e.Message,
                    "END "+ e.HResult +" EXCEPTION" };
                IEnumerable<string> content = exArray;
                ew.Write(ErrorTypes.Exceptions, content);
                return "Errore nel registro.";
            }
        }

        /// <summary>
        /// Controlla se la chiave immessa esiste
        /// </summary>
        /// <param name="key">Il percorso della chiave</param>
        /// <returns>
        /// TRUE - se esiste
        /// FALSE - se non esiste o sono insorte eccezioni
        /// </returns>
        public static bool KeyExist(string key)
        {
            try
            {
                if (AccessKey().OpenSubKey(key) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                ExceptionWriter ew = new ExceptionWriter();
                string[] exArray = { "BEGIN "+ e.HResult +" MESSAGE",
                    DateTime.Now.ToString("r") + " - Messaggio: " + e.Message,
                    "END "+ e.HResult +" EXCEPTION" };
                IEnumerable<string> content = exArray;
                ew.Write(ErrorTypes.Exceptions, content);
                return false;
            }
        }
        /// <summary>
        /// Metodo usato per ridurre lo spreco di ram utilizzando un solo oggetto istanziato su più metodi
        /// </summary>
        /// <returns></returns>
        public static RegistryKey AccessKey()
        {
            RegistryKey accessKey = Registry.CurrentUser;
            accessKey.Close();
            return accessKey;
        }
    }
}
