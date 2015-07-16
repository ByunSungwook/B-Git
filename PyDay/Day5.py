#-*coding:utf-8-*-
from flaskext.mysql import MySQL
mysql = MySQL()
app = Flask(__name__)
app.config['MYSQL_DATABASE_USER'] = 'serverstudy'
app.config['MYSQL_DATABASE_PASSWORD'] = 'serverstudy!@#'
app.config['MYSQL_DATABASE_DB'] = 'serverstudy'
app.config['MYSQL_DATABASE_HOST'] = 'data.khuhacker.com'
app.config['MYSQL_CHARSET']='utf-8'
mysql.init_app(app)

@app.route('/userlist/')
def showuser():
    cur = mysql.connect().cursor()
    cur.execute("select * from sw_users")
    data = cur.fetchall()
    cur.close()
    print data