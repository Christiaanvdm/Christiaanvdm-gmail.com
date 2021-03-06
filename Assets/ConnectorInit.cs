﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Complete {
public class ConnectorInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRoom(int mazeDepth) {
        var rooms = Resources.LoadAll<GameObject>("Rooms/South");
        var room = rooms.First(x => x.name == "ARoom2");
        GameObject newRoom = Instantiate(room) as GameObject;
        var entrance = transform.Find("Exit");

        newRoom.transform.position = entrance.position + (newRoom.transform.position - newRoom.transform.Find("Entrance").position);
        newRoom.transform.Find("RoomArea").GetComponent<RoomManager>().InitializeMap(mazeDepth);
    }
}
}