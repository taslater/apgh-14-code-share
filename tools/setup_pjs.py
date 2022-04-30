import os
from pathlib import Path

current_dir = '../Week 4/Projects/Calculator Testing/'
# print(os.listdir(current_dir))

pj_names = ['Jessica_Yemi_Joe_Imani',
            'Tom_Rich_Renat_Andrew',
            'Tobias_Jeremy_Spenser_Donna',
            'Harrison_Shauna_James_David']

pj_structure = [('/lib',  ['calulator.rb']),
                ('/spec', ['calulator_spec.rb'])]


for pj_name in pj_names:
    dir_name = current_dir + pj_name
    os.mkdir(dir_name)
    for sub_dir, filenames in pj_structure:
        sub_dir_path = '/'.join([dir_name, sub_dir])
        os.mkdir(sub_dir_path)
        for filename in filenames:
            file_path = '/'.join([sub_dir_path, filename])
            Path(file_path).touch()
            # if filename == 'calulator_spec.rb':
            #     with open(file_path, "w") as f:
            #         f.write(spec_text)
