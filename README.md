# SerialportCheck

2017.05.16. Done by ZongHan, WU.

Hello, this is my first program for C#, it makes you to connect UART device and test it. The receive string will update to listbox, and the listBox will clear after received 100 of data.
The radiobutton "SerialPort" can only let user receive data from USAT device (type: string), the radiobutton "Motor" provide you sent the data to the device throught UART.
ComboBox "EOS" means End Of String, if you don't want any EOS with your data, pls let ComboBox "EOS" be "NONE".

Oh, the Serial_1 and serial_2 are using read buffer, and the Serial_3 and serial_4 are using readline.
You can reconnect after disconnect, but sometimes will get error. I'm tring to fix it ASAP.
* If you have any good idea or suggestions, I appreciate to receive it. :))
