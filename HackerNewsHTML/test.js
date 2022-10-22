
const usernameList = [
    "Homer29",
    "PatrickStar1",
    "Peppa Pig",
    "PeterGriffin",
    "Quagmire",
    "Naruto32525",
    "Squidwardtentacles.exe",
    "Krustykrabisthebest",
    "Mickeymouse1921",
    "NotBruceWayne"
];
const titleList = [
    "A look under the hood of the new student loan debt relief application ",
    "My Guide to a Deglobalising World ",
    "What We Know About All the New Covid Variants ",
    "Another scientific body has debunked bitemark analysis ",
    "The Mystery of 355/113 (2010)",
    "The Overflow Offline project",
    "A Bluetooth Low Energy soil moisture sensor",
    "Ubuntu 22.10 Kinetic Kudu (",
    "Nabla – Isometric Color Font",
    "Ammonia combustion engines: latest research (2021)"
];

let index = 1;

function generateThreads(amount) {
    for (let i = 1; i < amount; i++) {
        createThreadBox()
        index++;
    }
}

//create 30 threads when window loads
window.onload = generateThreads(30)
//create thread box and add it to html container
function createThreadBox() {

    // new instance of thread object
    var t = new Thread(usernameList[getRandomInt(0, usernameList.length)], 
    titleList[getRandomInt(0, titleList.length)])

    // get container
    var container = document.getElementById("threadcontainer")
    
    // create threadbox div
    const threadbox = document.createElement("div");
    threadbox.classList.add("threadbox");
    const node = document.createTextNode("");
    container.appendChild(node);

    //add left content of threadbox
    const leftcontent = document.createElement("div");
    leftcontent.classList.add("leftcontent")
    leftcontent.innerHTML ="<span id='index'>" + index + ".</span><button class='btnUpVote' id='btnUpVote'>^</button>"
    threadbox.appendChild(leftcontent);

    //add right content of threadbox
    const rightcontent = document.createElement("div");
    rightcontent.classList.add("rightcontent")
    
    //create children of rightcontent div
    const top = document.createElement("div")
    top.innerHTML = "<span id='title'>" + t.title + "</span>"
    top.classList.add("top")
    const bottom = document.createElement("div")
    bottom.innerHTML ="<span id='details'>" + getRandomInt(0,500) + " points by " + t.username + " " + getRandomInt(1,23) + " " + "hours ago | hide | " + getRandomInt(0,150) + " comments</span>"
    bottom.classList.add("bottom")

    //add to html
    rightcontent.appendChild(top)
    rightcontent.appendChild(bottom)

    //add right content
    threadbox.appendChild(rightcontent)
}

// Thread object
function Thread(usrn, ttl) {
    this.username = usrn
    this.title = ttl;
}

// function to get random int variable
function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); 
}

function RefreshPage() {
    location.reload();
}