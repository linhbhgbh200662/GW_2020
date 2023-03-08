const { Int32, ObjectId } = require('bson')
var expesss = require('express')
const { insertProduct, getAllProducts, deleteProductById, 
        updateProduct, findProductById, searchProductByName } = require('./databaseHandler')   /// use insert products lấy trong file database
var app = expesss()

app.set('view engine','hbs')
app.use(expesss.urlencoded({extended:true}))

app.post('/search', async(req,res)=>
{
    const search = req.body.search
    const result = await searchProductByName(search)
    res.render('allProduct',{'results':result})
})

app.post('/edit',async (req,res)=>{
    const id = req.body.id
    const name = req.body.txtName
    const price = req.body.txtPrice
    const picture = req.body.txtPic
    await updateProduct(id, name, price, picture)
    res.redirect('/all')
})

app.get('/edit',async (req,res)=>{
    const id = req.query.id
    const productToEdit = await findProductById(id)
    res.render('edit',{product:productToEdit})
})

app.get('/delete', async(req,res)=>
{
    const id = req.query.id
    await deleteProductById(id)
    res.redirect('/all')
})
app.get('/all', async(req,res)=>
{
    let results = await getAllProducts()
    res.render('allProduct',{results:results})
})

app.post('/new',async (req,res)=>
{
    const name = req.body.txtName
    const price = req.body.txtPrice
    const picUrl = req.body.txtPic
    const newProduct = {
        name :name,
        price: Number.parseFloat(price),
        picture: picUrl
    }
    let id = await insertProduct(newProduct)
    console.log(id)
    res.render('home')

})

app.get('/new',(req,res)=>{
    res.render('newProduct')
})

app.get('/',(req,res)=>{
    res.render('home')
})

const PORT = process.env.PORT || 3000
app.listen(PORT)
console.log("Server is running!")











