var express = require('express')
const { insertNewCustomer, getAllCustomer } = require('./customerService')
var router = express.Router()

router.post('/create',async (req,res)=>{
    const name = req.body.txtName
    const age = req.body.txtAge
    const customer = {
        name: name,
        age: age
    }
    await insertNewCustomer(customer)
    res.redirect('/customer')
})

router.get("/",async (req,res)=>{
    const result = await getAllCustomer()
    res.render("customer/customerHome",{result:result})
})

router.get('/create',(req,res)=>{
    res.render("customer/createCustomer")
})
module.exports = router