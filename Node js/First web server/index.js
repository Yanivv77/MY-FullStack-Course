const express = require('express')

const app = express()
app.use(express.json())

const courses = [
  { id: 1, name: 'c#' },
  { id: 2, name: 'java' },
  { id: 3, name: 'python' },
]
app.get('/', (req, res) => {
  res.send('Hello world')
})

app.get('/api/courses', (req, res) => {
  res.send(courses)
})
app.get('/api/courses/:id', (req, res) => {
  console.log(req.params)
  let course = courses.find((c) => c.id === parseInt(req.params.id))
  if (course === undefined) {
    res.status(400).send('course is not found')
  } else {
    res.send(course)
  }
})

app.post('/api/courses', (req, res) => {
  console.log('body data: ', req.body)
  let id = courses.length + 1
  let course = {
    id: id,
    name: req.body.name,
  }
  courses.push(course)
  res.send(course)
})

const port = process.env.PORT

app.get('/api/posts/:year/:month', (req, res) => {
  res.send(req.params)
})

app.listen(port, () => {
  console.log(`Listening on port ${port}`)
})
