let app = document.getElementById('app')

app.innerHTML = 'new text'

let getDrivers = function(){
    let url = "https://localhost"
    fetch(url).then(function(response){
        console.log(response)
        return response.json()
    }).then(function(json){
        let html = "<ul>"
        json.ForEach((app)=>{
            html += "<li>" + "name" + app.name + "ID:" + app.Id + "DOH" + app.dateHired + "Rating:" + app.Rating + "</li>"
        })
        html += "</ul>"
        document.getElementById("app").innerHTML = html;
        console.log(json)

    }).catch(function(error){
        console.log(error)
    })
}