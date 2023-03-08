var express = require('express')
var fs = require('fs')
var app = express()

app.set('view engine','hbs')
app.use(express.urlencoded({express:true}))

app.get('readFile', (req,res)=>
{
    
})
app.post('register',(req,res)=>
{
    const name = req.body.txtName
    const country = req.body.country
    const content = name +";" + country
    fs.writeFileSync("data.txt", content)
    res.render('confirm',{'name':name,'country':country})
})

app.get('/',function (req,res) // or => ở đoạn này thì bỏ function
{
    const options = { weekend: 'long', year: 'numeric', month: 'long', day: 'numeric'}
    const date = new Date(Date.UTC(2022, 11, 20, 3, 0, 0));
    let n = date.toLocaleDateString('vi-VN', options)
    console.log(n);
    // let n = new Date().toLocaleDateString('vi-VN', options)
    res.render('Home', {now:n})
})

app.get('student', (req,res)=>
{
    res.render('student')
})

const PORT = 5000
app.listen(PORT)
console.log("Server is running")