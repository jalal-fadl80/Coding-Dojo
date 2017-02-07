from flask import Flask
app = Flask(__name__)
@app.route('/')
def hello_world():
     return '<h1 align="center" style="color:red";> hello_world </h1>'
app.run(debug=True)
