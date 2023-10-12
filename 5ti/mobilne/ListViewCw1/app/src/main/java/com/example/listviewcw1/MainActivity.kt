package com.example.listviewcw1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val button = findViewById<Button>(R.id.btn1)
        val listView = findViewById<ListView>(R.id.listview1)
        val editText = findViewById<EditText>(R.id.ed1)
        val myList = arrayListOf<String>("Zjeść śniadanie","Umyć się","w..... się");
        val listAdapter = ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,myList)
        listView.adapter = listAdapter

        button.setOnClickListener {
            val item = editText.text.toString()
            if(item.isEmpty()) return@setOnClickListener
            myList.add(item)
            listAdapter.notifyDataSetChanged()
        }
        listView.onItemClickListener = AdapterView.OnItemClickListener{
                adapterView,view,position,id ->
            val selectedItem = adapterView.getItemAtPosition(position) as String
            val itemAtPos = adapterView.getItemIdAtPosition(position)
            Toast.makeText(this@MainActivity,
                "elemnt klikniety: $selectedItem na pozycji $itemAtPos -> $id",Toast.LENGTH_LONG).show()
            myList.removeAt(id.toInt())
            listAdapter.notifyDataSetChanged()
        }

    }
}