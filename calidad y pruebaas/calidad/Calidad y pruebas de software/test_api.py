import requests

class ApiV1:
    def __init__(self, url):
        self.url = url

    def call(self, id):
        retry = 5

        while True:
            try:
                response = requests.get(self.url + str(id))
                return response.json()
            except:
                retry -= 1
                if retry == 0:
                    raise Exception('No response from server')
if __name__ == "__main__":
    api = ApiV1("https://jsonplaceholder.typicode.com/users/")
    print(api.call(3))
