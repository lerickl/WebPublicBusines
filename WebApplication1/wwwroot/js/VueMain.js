
var appRegistroUser = Vue.createApp;
appRegistroUser({
    data() {
        return {
            message: '',
            resp: {
                Error: null,
                Message: null
            },
            user: {
                Email: null,
                Password: null
            }
        }
    },
    methods: {
        createUser() {
            let self = this;
            axios.post("/home/Register", this.user)
                .then(function (response) {
                    self.resp.Error = response.data.error;
                    self.resp.Message = response.data.message
                    console.log("Error");
                    console.log(self.resp.Error);
                    console.log("message");
                    console.log(self.resp.Message);
                    if (self.resp.Error == "200") {
                        window.location.replace("https://localhost:7245/usuario/index");
                    }
                }).catch(function (error) {
                    //console.log(error);
                    console.log("error peticion html");
                });
        }
    }

}).mount("#RegistroUserForm");


var appRegistroEmpresa = Vue.createApp;
    appRegistroEmpresa({
    data() {
        return {
            message: '',
            resp: {
                Error: null,
                Message: null
            },
            empresa: {
                NombreComercial: null,
                Email: null,
                Password: null,
                Telefono: null

            }
        }
    },
    methods: {
        createEmpresa()
        {
            var dat = {
                Error: null,
                Message: null
            };
            let self = this;
            axios.post("/home/RegistrarEmpr", this.empresa)
                .then(function (response) {
                    self.resp.Error = response.data.error;
                    self.resp.Message = response.data.message
                    console.log("Error");
                    console.log(self.resp.Error);
                    console.log("message");
                    console.log(self.resp.Message);
                    if (self.resp.Error == "200") {
                        window.location.replace("https://localhost:7245/empresa/index");
                    }
                }).catch(function (error) {
                    //console.log(error);
                    console.log("error peticion html");
                });
        }
    }


}).mount("#RegistroEmpresaForm");
   
    var createApp = Vue.createApp;

    createApp({

        data() {
            return {
                message: 'Hello Vue!',
                contador: 0,
                usuario: {
                    email: null,
                    password: null
                },
                resp: {
                    text: null,
                    content: null
                }
            }
        },

        methods: {
            submitUser() {

                console.log("userEnviado");
            },
            procesarS() {
                /* httpPost area*/
                var dat = {
                    text: null,
                    content: null
                };

                let self = this;
                console.log(self.usuario.email);

                axios.post("/home/Login", this.usuario)
                    .then(function (response) {
                        console.log(response);

                        self.resp.text = response.data.text;
                        self.resp.content = response.data.content;
                        console.log("resp");
                        console.log(self.resp.text);
                        console.log("menssage");
                        console.log(self.resp.content);
                        if (self.resp.content == 'usuario') {
                            window.location.replace("https://localhost:7245/usuario/index");
                        } else if (self.resp.content == 'empresa') {
                            window.location.replace("https://localhost:7245/empresa/index");
                        }

                    })
                    .catch(function (error) {
                        //console.log(error);
                        console.log("error peticion html");
                    });
                console.log("menssage");
                console.log(dat.content);
                /*httpPost area*/

            },
            contadorS() {
                console.log("hola");
                this.usuario.password = this.usuario.email;
            }
        }

    }).mount('#example-1');
     
    
