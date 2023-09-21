package com.example.cw2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.Spinner
import android.widget.TextView
import android.widget.Toast
import java.lang.NumberFormatException

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val aInput = findViewById<EditText>(R.id.editTextNumberA)
        val bInput = findViewById<EditText>(R.id.editTextNumberB)
        val addButton = findViewById<Button>(R.id.buttonAdd)
        val tvResult = findViewById<TextView>(R.id.textViewResult)
        val spinner = findViewById<Spinner>(R.id.spinner)
        val tasks = resources.getStringArray(R.array.tasks)
        if(spinner!=null){
            val adapter = ArrayAdapter(this,android.R.layout.simple_spinner_item,tasks)
            spinner.adapter = adapter
        }
        addButton.setOnClickListener {
            runTask(aInput, bInput, tvResult,0)

        }
        spinner.onItemSelectedListener = object :
       AdapterView.OnItemSelectedListener{
            override fun onItemSelected(p0: AdapterView<*>?, p1: View?, position: Int, p3: Long) {
                val choice = tasks[position]
                runTask(aInput,bInput,tvResult,position)
                //Toast.makeText(this@MainActivity,choice,Toast.LENGTH_LONG).show()
            }

            override fun onNothingSelected(p0: AdapterView<*>?) {
                TODO("Not yet implemented")
            }
        }

    }

    private fun runTask(
        aInput: EditText,
        bInput: EditText,
        tvResult: TextView,
        task:Int
    ) {
        try {
            val a = aInput.text.toString().toDouble();
            val b = bInput.text.toString().toDouble();
            when(task){
                0-> tvResult.text = "$a + $b = " + (a + b).toString()
                1-> tvResult.text = "$a - $b = " + (a - b).toString()
                2-> tvResult.text = "$a * $b = " + (a * b).toString()
                3-> tvResult.text = if(b!=0.0) "$a / $b = " + (a / b).toString()
                                     else "$a / $b = Dzielenie przez zero"
                else -> {
                    tvResult.text = "Błędne działanie"
                }
            }

        } catch (e: NumberFormatException) {
            Toast.makeText(this@MainActivity, "Błędne dane", Toast.LENGTH_SHORT).show()
        }
    }
}