using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sands
{   
    public static class SaveSystem
    {

        public static void SavePlayer(Player player) {

            BinaryFormatter formatter = new BinaryFormatter();

            string path = Application.persistentDataPath + "/player.savefile";

            FileStream stream = new FileStream(path, FileMode.Create);
            
            PlayerData data = new PlayerData(player);

            formatter.Serialize(stream, data);
            stream.Close();
    

        }

        public static PlayerData LoadPlayer() {

            
        }
    }
}