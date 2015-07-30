#-*- coding: utf-8 -*-
from flask import Flask , render_template
from flaskext.mysql import MySQL
app = Flask(__name__)
mysql = MySQL
app.config["MYSQL_DATABASE_USER"]="serverstudy"
app.config["MYSQL_DATABASE_PASSWORD"]="serverstudy!@#"
app.config["MYSQL_DATABASE_HOST"]="data.khuhacker.com"
app.config["MYSQL_CHARSET"]="utf-8"
mysql.init_app(app)

@app.route('/userlist/')
def showuser():
    cur = mysql.connect().cursor()
    cur.execute("SELECT * FROM sw_twitter")
    data = cur.fetchall()
    cur.close()
    output = ""
    for user in data:
        output += "INDEX : {0}<br> AUTHOR : {1}<br> CONTENT : {2}<br>"
    return output

@app.route('/tweet/', method=['POST'])
def tweet():
    return render_template('tweet.html')

@app.route('/submit/', method=['POST'])
def submit():
    if tweet.form == 'POST':
        author = tweet.form['author']
        content = tweet.form['content']
    return "success"

if __name__=='__main__':
    app.run()
