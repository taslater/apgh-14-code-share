import os
from pathlib import Path

current_dir = '../Week 4/Projects/Mario/'
# print(os.listdir(current_dir))

pj_names = ['Jessica_Donna_Spenser_Harrison',
            'Tobias_David_Renat_Imani',
            'Shauna_Jeremy_Joe_James',
            'Andrew_Yemi_Tom_Rich']
# pj_structure = [('/lib',  ['calulator.rb']),
#                 ('/spec', ['calulator_spec.rb'])]


for pj_name in pj_names:
    dir_name = current_dir + pj_name
    Path(dir_name + '.rb').touch()
    # os.mkdir(dir_name)
    # for sub_dir, filenames in pj_structure:
    #     sub_dir_path = '/'.join([dir_name, sub_dir])
    #     os.mkdir(sub_dir_path)
    #     for filename in filenames:
    #         file_path = '/'.join([sub_dir_path, filename])
    #         Path(file_path).touch()
    #         # if filename == 'calulator_spec.rb':
    #         #     with open(file_path, "w") as f:
    #         #         f.write(spec_text)
