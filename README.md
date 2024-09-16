# Administração de Usuários

## Integrantes 
- Luiza Nunes de Jesus 
- Melissa de Oliveira Pecoraro 
- Pamella Schimalesky Engholm 
- Pedro Marques Pais Pavão 
- Roberto Menezes dos Santos

## Tecnologias

- [.NET 8.0](https://dotnet.microsoft.com/pt-br/)
- [Mongo DB](https://www.mongodb.com/pt-br)
- [Swagger](https://swagger.io/)

## Ferramenta

- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/)

 # Arquitetura da API
 
A arquitetura monolítica foi escolhida diante dos benefícios que ofereceu ao nosso projeto, como sua simplicidade em projetos que estão em fases iniciais de desenvolvimento, sendo simples de implementar e exigindo menos complexidade. Sua facilidade de gerenciamento e custo de desenvolvimento também foram levados em consideração, afinal como todo o código se encontra concentrado em uma única aplicação, o gerenciamento se torna mais fácil. Falando sobre custos, o desenvolvimento monolítico tende a ser mais rápido e mais barato para começar, pensando em Startups iniciando no mercado, serviços que são mais baratos se tornam essenciais.  

## Getting Started

Primeiro clone o projeto em sua máquina: 
```
git clone https://github.com/LuizaNs/AdmUsuarios.git
```

Após isso, abra a pasta em que o projeto está salvo na sua IDE de preferência. A utilizada para o desenvolvimento foi o Visual Studio 2022. 

# Documentação da API

## Usuário

`[HttpGet]`

### Retorna todos os Usuários cadastrados
| Código | Descrição                             |
|--------|---------------------------------------|
| 200    | Retorna todos os usuários registrados |

`[HttpGet("{id}")]`

### Retorna o Usuário pelo seu ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna o usuário com o id enviado                  |
| 404    | Caso o usuário com o id enviado não seja encontrado |

`[HttpPost]`

### Cria um Usuário
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 201    | Retorna o usuário recém-criado                      |

`[HttpPut("{id}")]`

### Atualiza um Usuário pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna caso o usuário seja atualizado com sucesso  |
| 404    | Caso o usuário com o id enviado não seja encontrado |

`[HttpDelete("{id}")]`

### Deleta um Usuário pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 204    | Retorna caso o usuário seja deletado com sucesso    |
| 404    | Caso o usuário com o id enviado não seja encontrado |

## Empresa

`[HttpGet]`

### Retorna todas as Empresas cadastradas
| Código | Descrição                             |
|--------|---------------------------------------|
| 200    | Retorna todas as empresas registradas |

`[HttpGet("{id}")]`

### Retorna a Empresa pelo seu ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna a empresa com o id enviado                  |
| 404    | Caso a empresa com o id enviado não seja encontrada |

`[HttpPost]`

### Cria uma Empresa
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 201    | Retorna a empresa recém-criada                      |

`[HttpPut("{id}")]`

### Atualiza uma Empresa pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna caso a empresa seja atualizada com sucesso  |
| 404    | Caso a empresa com o id enviado não seja encontrada |

`[HttpDelete("{id}")]`

### Deleta uma Empresa pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 204    | Retorna caso a empresa seja deletada com sucesso    |
| 404    | Caso a empresa com o id enviado não seja encontrada |

## Cidade

`[HttpGet]`

### Retorna todas as Cidades cadastradas
| Código | Descrição                             |
|--------|---------------------------------------|
| 200    | Retorna todas as cidades registradas  |

`[HttpGet("{id}")]`

### Retorna a Cidade pelo seu ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna a cidade com o id enviado                   |
| 404    | Caso a cidade com o id enviado não seja encontrada  |

`[HttpPost]`

### Cria uma Cidade
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 201    | Retorna a cidade recém-criada                       |

`[HttpPut("{id}")]`

### Atualiza uma Cidade pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna caso a cidade seja atualizada com sucesso   |
| 404    | Caso a cidade com o id enviado não seja encontrada  |

`[HttpDelete("{id}")]`

### Deleta uma Cidade pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 204    | Retorna caso a cidade seja deletada com sucesso     |
| 404    | Caso a cidade com o id enviado não seja encontrada  |

## Estado

`[HttpGet]`

### Retorna todos os Estados cadastrados
| Código | Descrição                             |
|--------|---------------------------------------|
| 200    | Retorna todos os estados registradas  |

`[HttpGet("{id}")]`

### Retorna o Estado pelo seu ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna o estado com o id enviado                   |
| 404    | Caso o estado com o id enviado não seja encontrado  |

`[HttpPost]`

### Cria um Estado
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 201    | Retorna o estado recém-criado                       |

`[HttpPut("{id}")]`

### Atualiza um Estado pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 200    | Retorna caso o estado seja atualizado com sucesso   |
| 404    | Caso o estado com o id enviado não seja encontrado  |

`[HttpDelete("{id}")]`

### Deleta uma Estado pelo ID
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 204    | Retorna caso o estado seja deletado com sucesso     |
| 404    | Caso o estado com o id enviado não seja encontrado  |

## Logradouro

`[HttpGet]`

### Retorna todos os Logradouros cadastrados
| Código | Descrição                                 |
|--------|-------------------------------------------|
| 200    | Retorna todos os logradouros registrados  |

`[HttpGet("{id}")]`

### Retorna o Logradouro pelo seu ID
| Código | Descrição                                               |
|--------|---------------------------------------------------------|
| 200    | Retorna o logradouro com o id enviado                   |
| 404    | Caso o logradouro com o id enviado não seja encontrado  |

`[HttpPost]`

### Cria um Logradouro
| Código | Descrição                                           |
|--------|-----------------------------------------------------|
| 201    | Retorna o logradouro recém-criado                   |

`[HttpPut("{id}")]`

### Atualiza um Logradouro pelo ID
| Código | Descrição                                               |
|--------|---------------------------------------------------------|
| 200    | Retorna caso o logradouro seja atualizado com sucesso   |
| 404    | Caso o logradouro com o id enviado não seja encontrado  |

`[HttpDelete("{id}")]`

### Deleta uma Logradouro pelo ID
| Código | Descrição                                               |
|--------|---------------------------------------------------------|
| 204    | Retorna caso o logradouro seja deletado com sucesso     |
| 404    | Caso o logradouro com o id enviado não seja encontrado  |
