import json
import os
import shutil

save_path = './code_messages/'

if os.path.isdir(save_path):
    shutil.rmtree(save_path)

os.mkdir(save_path)


json_path = './matrix-export-4-17-2022 at 1-15-29 PM.json'

with open(json_path) as f:
    data = json.load(f)
    messages = data['messages']

count = 0
for message in messages:
    content = message['content']
    keys = content.keys()
    if 'body' not in keys:
        continue
    body = content['body']
    # sender, age, event_id
    # not every message has an age
    if '{' in body:
        sender = message['sender'][1:].split(':')[0]
        with open(f'{save_path}{count:03}_{sender}.txt', 'w') as outfile:
            outfile.write(body)
        count += 1

